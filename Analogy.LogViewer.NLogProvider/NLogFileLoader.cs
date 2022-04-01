using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;

namespace Analogy.LogViewer.NLogProvider
{
    public class NLogFileLoader
    {
        private ISplitterLogParserSettings _logFileSettings;
        private NLogFileParser _parser;
        public NLogFileLoader(ISplitterLogParserSettings logFileSettings)
        {
            _logFileSettings = logFileSettings;
            _parser = new NLogFileParser(_logFileSettings);
        }
        public async Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File is null or empty. Aborting.",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, Utils.GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }
            if (!_logFileSettings.IsConfigured)
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File Parser is not configured. Please set it first in the settings Window",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, Utils.GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }
            if (!_logFileSettings.CanOpenFile(fileName))
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File {fileName} Is not supported or not configured correctly in the windows settings",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, Utils.GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }
            List<AnalogyLogMessage> messages = new List<AnalogyLogMessage>();
            try
            {
                using (var stream = File.OpenRead(fileName))
                {
                    long count = 0;
                    using (var reader = new StreamReader(stream))
                    {
                        var line = await reader.ReadLineAsync();
                        while (!reader.EndOfStream)
                        {
                            var nextLine = await reader.ReadLineAsync();
                            var hasSeparators = _parser.splitters.Any(nextLine.Contains);
                            if (!hasSeparators) // handle multi-line messages
                            {
                                line = line + Environment.NewLine + nextLine;
                            }
                            else
                            {
                                var entry = _parser.Parse(line);
                                messages.Add(entry);
                                line = nextLine;
                            }

                        }
                        var entry1 = _parser.Parse(line);
                        messages.Add(entry1);
                        count++;
                        messagesHandler.ReportFileReadProgress(new AnalogyFileReadProgress(AnalogyFileReadProgressType.Incremental, 1, count, count));
                    }
                }
                messagesHandler.AppendMessages(messages, fileName);
                return messages;
            }
            catch (Exception e)
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"Error occured processing file {fileName}. Reason: {e.Message}",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, Utils.GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }
        }
    }
}
