using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Newtonsoft.Json;

namespace Analogy.LogViewer.NLogProvider
{
    public class NLogDataProvider : IAnalogyOfflineDataProvider
    {
        public string OptionalTitle { get; set; } = "Analogy Built-In NLog Parser";
        public Guid Id { get; set; } = new Guid("4C002803-607F-4385-9C19-949FF1F29877");
        public Image LargeImage { get; set; } = null;
        public Image SmallImage { get; set; } = null;
        public bool CanSaveToLogFile { get; } = false;
        public string FileOpenDialogFilters { get; } = "Nlog files|*.log;*.nlog|NLog file (*.log)|*.log|NLog File (*.nlog)|*.nlog";
        public string FileSaveDialogFilters { get; } = string.Empty;
        public IEnumerable<string> SupportFormats { get; } = new[] { "*.nlog", "*.log" };

        public string InitialFolderFullPath => Directory.Exists(UserSettings?.Directory)
            ? UserSettings.Directory
            : Environment.CurrentDirectory;
        public NLogFileLoader nLogFileParser { get; set; }

        private ISplitterLogParserSettings UserSettings { get; set; }
        public bool UseCustomColors { get; set; } = false;
        public IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
            => Array.Empty<(string, string)>();

        public (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);
        public NLogDataProvider(ISplitterLogParserSettings userSettings)
        {
            UserSettings = userSettings;
        }

        public Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            LogManager.Instance.SetLogger(logger);
            nLogFileParser = new NLogFileLoader(UserSettingsManager.UserSettings.LogParserSettings);
            return Task.CompletedTask;
        }

        public void MessageOpened(AnalogyLogMessage message)
        {
            //nop
        }
        public async Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (CanOpenFile(fileName))
            {
                return await nLogFileParser.Process(fileName, token, messagesHandler);
            }

            return new List<AnalogyLogMessage>(0);

        }

        public IEnumerable<FileInfo> GetSupportedFiles(DirectoryInfo dirInfo, bool recursiveLoad)
            => GetSupportedFilesInternal(dirInfo, recursiveLoad);

        public Task SaveAsync(List<AnalogyLogMessage> messages, string fileName)
        {
            throw new NotSupportedException("Saving is not supported for nlog");
        }

        public bool CanOpenFile(string fileName) => UserSettingsManager.UserSettings.LogParserSettings.CanOpenFile(fileName);

        public bool CanOpenAllFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);
        public bool DisableFilePoolingOption { get; } = false;
        public static List<FileInfo> GetSupportedFilesInternal(DirectoryInfo dirInfo, bool recursive)
        {
            List<FileInfo> files = dirInfo.GetFiles("*.log")
                .Concat(dirInfo.GetFiles("*.nlog"))
                .ToList();
            if (!recursive)
            {
                return files;
            }

            try
            {
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    files.AddRange(GetSupportedFilesInternal(dir, true));
                }
            }
            catch (Exception)
            {
                return files;
            }

            return files;
        }
    }
}
