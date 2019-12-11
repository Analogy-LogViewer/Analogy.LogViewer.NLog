using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analogy.DataProviders.Extensions;
using Analogy.Interfaces;
using Newtonsoft.Json;

namespace Analogy.LogViewer.NLogProvider
{
    public class UserSettingsManager
    {
        private static readonly string splitter = "*#*#*#";

        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());
        public static UserSettingsManager UserSettings { get; set; } = _instance.Value;
        private string NLogFileSetting { get; } = "AnalogyNLogSettings.json";
        public ILogParserSettings LogParserSettings { get; set; }


        public UserSettingsManager()
        {
            if (File.Exists(NLogFileSetting))
            {
                try
                {
                    string data = File.ReadAllText(NLogFileSetting);
                    LogParserSettings = JsonConvert.DeserializeObject<LogParserSettings>(data);
                }
                catch (Exception ex)
                {
                    LogParserSettings = new LogParserSettings();
                    LogParserSettings.Splitter = "|";
                    LogParserSettings.SupportedFilesExtensions = new List<string> { "*.Nlog" };
                }
            }
            else
            {
                LogParserSettings = new LogParserSettings();
                LogParserSettings.Splitter = "|";
                LogParserSettings.SupportedFilesExtensions = new List<string> { "*.Nlog" };

            }
          
        }

        public void Save()
        {
            try
            {
                File.WriteAllText(NLogFileSetting, LogParserSettings.AsJson());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}
