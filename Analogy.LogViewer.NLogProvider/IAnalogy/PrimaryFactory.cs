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

    public class PrimaryFactory : Template.PrimaryFactory
    {
        public static Guid Id { get; } = new Guid("33CBFA00-DA3E-4F9F-B5A1-BE978FD09D57");

        public override Guid FactoryId { get; set; } = Id;
        public override string Title { get; set; } = "NLogs Parser";
        public override IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = NLogProvider.ChangeLog.GetChangeLog();
        public override IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public override string About { get; set; } = "Analogy NLogs Parser";
        public override Image? SmallImage { get; set; } = Resources.nlog_icon_16x16;
        public override Image? LargeImage { get; set; } = Resources.nlog_icon_32x32;


    }

    public class AnalogyNLogDataProviderFactory : Template.DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "Analogy NLogs Data Provider";
        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } = new List<IAnalogyDataProvider> { new NLogDataProvider(UserSettingsManager.UserSettings.LogParserSettings) };
    }

    public class AnalogyNLogCustomActionFactory : IAnalogyCustomActionsFactory
    {
        public Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public string Title { get; set; } = "Analogy NLog Built-In tools";
        public IEnumerable<IAnalogyCustomAction> Actions { get; } = new List<IAnalogyCustomAction>(0);
    }

    public class AnalogyNLogSettings : Template.TemplateUserSettingsFactory
    {

        public override  Guid Id { get; set; } = new Guid("8D24EC70-60C0-4823-BE9C-F4A59303FFB3");
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "NLog Settings";
        public override UserControl DataProviderSettings { get; set; }
        public override Image? SmallImage { get; set; } = Resources.nlog;
        public override Image? LargeImage { get; set; } = null;

        public override void CreateUserControl(IAnalogyLogger logger)
        {
           DataProviderSettings = new NLogSettings();
        }

        public override Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }

    }
}
