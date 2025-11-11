using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.NLogProvider
{
    public class NLogDataProvider : Template.OfflineDataProviderWinForms
    {
        public override string OptionalTitle { get; set; } = "Analogy Built-In NLog Parser";
        public override Guid Id { get; set; } = new Guid("4C002803-607F-4385-9C19-949FF1F29877");
        public override Image? LargeImage { get; set; }
        public override Image? SmallImage { get; set; }
        public override bool CanSaveToLogFile { get; set; }
        public override string FileOpenDialogFilters { get; set; } = "Nlog files|*.log;*.nlog|NLog file (*.log)|*.log|NLog File (*.nlog)|*.nlog";
        public override string FileSaveDialogFilters { get; set; } = string.Empty;
        public override IEnumerable<string> SupportFormats { get; set; } = new[] { "*.nlog", "*.log" };

        public override string InitialFolderFullPath => Directory.Exists(UserSettings?.Directory)
            ? UserSettings.Directory
            : Environment.CurrentDirectory;
        public NLogFileLoader NLogFileParser { get; set; }

        private ISplitterLogParserSettings? UserSettings { get; set; }
        public override bool UseCustomColors { get; set; }

        public NLogDataProvider(ISplitterLogParserSettings userSettings)
        {
            UserSettings = userSettings;
        }

        public override Task InitializeDataProvider(ILogger logger)
        {
            NLogFileParser = new NLogFileLoader(UserSettingsManager.UserSettings.LogParserSettings);
            return base.InitializeDataProvider(logger);
        }

        public override async Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (CanOpenFile(fileName))
            {
                return await NLogFileParser.Process(fileName, token, messagesHandler);
            }

            return new List<AnalogyLogMessage>(0);
        }

        public override bool CanOpenFile(string fileName) => UserSettingsManager.UserSettings.LogParserSettings.CanOpenFile(fileName);

        protected override List<FileInfo> GetSupportedFilesInternal(DirectoryInfo dirInfo, bool recursive)
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