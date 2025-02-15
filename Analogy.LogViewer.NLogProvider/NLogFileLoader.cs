﻿using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.NLogProvider
{
    public class NLogFileLoader
    {
        private LogParserSettings logFileSettings;
        public NLogFileLoader(LogParserSettings logFileSettings)
        {
            this.logFileSettings = logFileSettings;
        }

        public async Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token,
            ILogMessageCreatedHandler messagesHandler)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                AnalogyLogMessage empty = new($"File is null or empty. Aborting.",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                };
                messagesHandler.AppendMessage(empty, Utils.GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }

            if (!logFileSettings.CanOpenFile(fileName))
            {
                AnalogyLogMessage empty = new AnalogyLogMessage(
                    $"File {fileName} Is not supported or not configured correctly in the windows settings",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                };
                messagesHandler.AppendMessage(empty, Utils.GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }

            List<IAnalogyLogMessage> messages = new();
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = logFileSettings.Splitter,
                    MissingFieldFound = (args => { }),
                };
                using var reader = new StreamReader(fileName);
                using var csv = new CsvReader(reader, config);
                AnalogyLogMessageRowRecordMapper mapper = new(logFileSettings);
                csv.Context.RegisterClassMap(mapper);
                IAnalogyLogMessage? previousEntry = null;
                foreach (var record in csv.GetRecords<ElasticRowRecord>())
                {
                    try
                    {
                        IAnalogyLogMessage entry = ParseMessage(record);
                        entry.RawText = csv.Parser.RawRecord;
                        if (string.IsNullOrEmpty(entry.Text) && previousEntry is not null)
                        {
                            previousEntry.Text += Environment.NewLine + entry.RawText;
                        }
                        else
                        {
                            if (previousEntry is not null)
                            {
                                messagesHandler.AppendMessage(previousEntry, fileName);
                                messages.Add(previousEntry);
                            }  
                            previousEntry = entry;
                        }
                    }
                    catch (Exception e)
                    {
                        AnalogyErrorMessage err = new AnalogyErrorMessage("Error Decrypting: " + e);
                        messagesHandler.AppendMessage(err, "Analogy");
                        messages.Add(err);
                    }
                }
                if (previousEntry is not null)
                {
                    messagesHandler.AppendMessage(previousEntry, fileName);
                    messages.Add(previousEntry);
                }
            }
            catch (Exception e)
            {
                AnalogyErrorMessage err = new AnalogyErrorMessage("Error Decrypting: " + e);
                messagesHandler.AppendMessage(err, "Analogy");
                messages.Add(err);
            }
            return messages;
        }

        private IAnalogyLogMessage ParseMessage(ElasticRowRecord record)
        {
            var m = new AnalogyLogMessage()
            {
                Text = record.Text,
                MachineName = record.MachineName,
                User = record.User,
                Module = record.ProcessName,
                Source = "",
                ThreadId = int.TryParse(record.ThreadId, NumberStyles.Any, new CultureInfo("en-US"), out var ti) ? ti : -1,
                ProcessId = int.TryParse(record.ProcessId, NumberStyles.Any, new CultureInfo("en-US"), out var pi) ? pi : -1,
                Level = AnalogyLogMessage.ParseLogLevelFromString(record.LogLevel),
                Date = ParseDateTime(record.Timestamp),
                LineNumber = long.TryParse(record.LineNumber, NumberStyles.Any, new CultureInfo("en-US"), out var ln) ? ln : -1,
                MethodName = record.MethodName,
                RawTextType = AnalogyRowTextType.None,
            };
            return m;
        }

        private DateTimeOffset ParseDateTime(string timestamp)
        {
            if (DateTimeOffset.TryParse(timestamp, out var time))
            {
                return time;
            }

            if (DateTimeOffset.TryParseExact(timestamp, logFileSettings.DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var formatted))
            {
                return formatted;
            }
            return DateTimeOffset.Now;
        }
    }

    public class ElasticRowRecord
    {
        public string Timestamp { get; set; }
        public string MachineName { get; set; }
        public string LogLevel { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public string ThreadId { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string MethodName { get; set; }
        public string LineNumber { get; set; }
        public string FileName { get; set; }
    }
    public sealed class AnalogyLogMessageRowRecordMapper : ClassMap<ElasticRowRecord>
    {
        public AnalogyLogMessageRowRecordMapper(ISplitterLogParserSettings logFileSettings)
        {
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.Date))
            {
                Map(m => m.Timestamp).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.Date).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.MachineName))
            {
                Map(m => m.MachineName).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.MachineName).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.Level))
            {
                Map(m => m.LogLevel).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.Level).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.Text))
            {
                Map(m => m.Text).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.Text).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.User))
            {
                Map(m => m.User).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.User).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.ThreadId))
            {
                Map(m => m.ThreadId).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.ThreadId).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.ProcessId))
            {
                Map(m => m.ProcessId).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.ProcessId).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.Module))
            {
                Map(m => m.ProcessName).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.Module).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.LineNumber))
            {
                Map(m => m.LineNumber).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.LineNumber).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.MethodName))
            {
                Map(m => m.MethodName).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.MethodName).Key);
            }
            if (logFileSettings.Maps.ContainsValue(AnalogyLogMessagePropertyName.FileName))
            {
                Map(m => m.FileName).Optional().Index(logFileSettings.Maps.First(f => f.Value == AnalogyLogMessagePropertyName.FileName).Key);
            }
        }
    }
}