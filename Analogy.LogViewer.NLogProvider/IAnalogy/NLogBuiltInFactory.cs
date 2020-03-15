using Analogy.DataProviders.Extensions;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.NLogProvider.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.NLogProvider
{

    public class NLogBuiltInFactory : IAnalogyFactory
    {
        public static Guid AnalogyNLogGuid { get; } = new Guid("33CBFA00-DA3E-4F9F-B5A1-BE978FD09D57");
        public Guid FactoryID { get; } = AnalogyNLogGuid;
        public string Title { get; } = "Analogy NLogs Parser";
        public IAnalogyDataProvidersFactory DataProviders { get; }
        public IAnalogyCustomActionsFactory Actions { get; }
        public IEnumerable<IAnalogyChangeLog> ChangeLog => NLogProvider.ChangeLog.GetChangeLog();
        public IEnumerable<string> Contributors { get; } = new List<string> { "Lior Banai" };
        public string About { get; } = "Analogy NLogs Parser";
        public NLogBuiltInFactory()
        {
            DataProviders = new AnalogyNLogDataProviderFactory();
            Actions = new AnalogyNLogCustomActionFactory();

        }


    }

    public class AnalogyNLogDataProviderFactory : IAnalogyDataProvidersFactory
    {
        public string Title { get; } = "Analogy NLogs Data Provider";
        public IEnumerable<IAnalogyDataProvider> Items { get; }

        public AnalogyNLogDataProviderFactory()
        {
            var builtInItems = new List<IAnalogyDataProvider>();
            var adpnlog = new NLogDataProvider(UserSettingsManager.UserSettings.LogParserSettings);
            builtInItems.Add(adpnlog);
            Items = builtInItems;
        }
    }

    public class AnalogyNLogCustomActionFactory : IAnalogyCustomActionsFactory
    {
        public string Title { get; } = "Analogy NLog Built-In tools";
        public IEnumerable<IAnalogyCustomAction> Items { get; }

        public AnalogyNLogCustomActionFactory()
        {
            Items = new List<IAnalogyCustomAction>(0);
        }
    }

    public class AnalogyNLogSettings : IAnalogyDataProviderSettings
    {

        public Guid ID { get; } = new Guid("8D24EC70-60C0-4823-BE9C-F4A59303FFB3");
        public Guid FactoryId { get; set; } = NLogBuiltInFactory.AnalogyNLogGuid;
        public string Title { get; } = "NLog Settings";
        public UserControl DataProviderSettings { get; } = new NLogSettings();
        public Image SmallImage { get; } = Resources.nlog;
        public Image LargeImage { get; }

        public Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }

    }
}
