using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Analogy.LogViewer.Template.Managers;
using Microsoft.Extensions.Logging;

namespace Analogy.LogViewer.NLogProvider
{
    public class UserSettingsManager
    {

        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());
        public static UserSettingsManager UserSettings { get; set; } = _instance.Value;
        private string NLogFileSetting { get; } = "AnalogyNLogSettings.json";
        public ISplitterLogParserSettings LogParserSettings { get; set; }


        public UserSettingsManager()
        {
            if (File.Exists(NLogFileSetting))
            {
                try
                {
                    string data = File.ReadAllText(NLogFileSetting);
                    LogParserSettings = JsonConvert.DeserializeObject<SplitterLogParserSettings>(data);
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogError(ex, "Error loading user setting file {message}", ex.Message);
                    LogParserSettings = new SplitterLogParserSettings();
                    LogParserSettings.Splitter = "|";
                    LogParserSettings.SupportedFilesExtensions = new List<string> { "*.Nlog" };
                }
            }
            else
            {
                LogParserSettings = new SplitterLogParserSettings();
                LogParserSettings.Splitter = "|";
                LogParserSettings.SupportedFilesExtensions = new List<string> { "*.Nlog" };

            }

        }

        public void Save()
        {
            try
            {
                File.WriteAllText(NLogFileSetting, JsonConvert.SerializeObject(LogParserSettings));
            }
            catch (Exception e)
            {
                LogManager.Instance.LogError(e, "Error saving settings: " + e.Message);
            }


        }
    }
}
