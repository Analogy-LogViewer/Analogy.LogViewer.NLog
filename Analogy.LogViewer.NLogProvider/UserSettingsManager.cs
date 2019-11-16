using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analogy.DataProviders.Extensions;
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
                    LogParserSettings = JsonConvert.DeserializeObject<LogParserSettings>(NLogFileSetting);
                }
                catch (Exception)
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
                var data = JsonConvert.SerializeObject(LogParserSettings);
                File.WriteAllText(NLogFileSetting,data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}
