using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.NLogProvider
{
    public partial class ColumnsMatcherUC : UserControl
    {
        private UserSettingsManager Settings => UserSettingsManager.UserSettings;

        public Dictionary<int, AnalogyLogMessagePropertyName> Mapping => GetMapping();
        public ColumnsMatcherUC()
        {
            InitializeComponent();
        }

        public void LoadMapping(ISplitterLogParserSettings parser)
        {
            void SetValue(NumericUpDown nud, AnalogyLogMessagePropertyName property)
            {
                if (Settings.LogParserSettings.Maps.ContainsValue(property))
                {
                    nud.Value = Settings.LogParserSettings.Maps.First(f => f.Value == property).Key;
                }
            }
            if (Settings.LogParserSettings.IsConfigured)
            {
                SetValue(nudDate, AnalogyLogMessagePropertyName.Date);
                SetValue(nudLevel, AnalogyLogMessagePropertyName.Level);
                SetValue(nudText, AnalogyLogMessagePropertyName.Text);
                SetValue(nudSource, AnalogyLogMessagePropertyName.Source);
                SetValue(nudProcessName, AnalogyLogMessagePropertyName.Module);
                SetValue(nudProcessId, AnalogyLogMessagePropertyName.ProcessId);
                SetValue(nudMachineName, AnalogyLogMessagePropertyName.MachineName);
                SetValue(nudUserName, AnalogyLogMessagePropertyName.User);
                SetValue(nudFileName, AnalogyLogMessagePropertyName.FileName);
                SetValue(nudMethodName, AnalogyLogMessagePropertyName.MethodName);
                SetValue(nudLineNumber, AnalogyLogMessagePropertyName.LineNumber);
            }
        }
        private Dictionary<int, AnalogyLogMessagePropertyName> GetMapping()
        {
            Dictionary<int, AnalogyLogMessagePropertyName> maps = new(11)
            {
                [decimal.ToInt32(nudDate.Value)] = AnalogyLogMessagePropertyName.Date,
                [decimal.ToInt32(nudLevel.Value)] = AnalogyLogMessagePropertyName.Level,
                [decimal.ToInt32(nudText.Value)] = AnalogyLogMessagePropertyName.Text,
                [decimal.ToInt32(nudSource.Value)] = AnalogyLogMessagePropertyName.Source,
                [decimal.ToInt32(nudProcessName.Value)] = AnalogyLogMessagePropertyName.Module,
                [decimal.ToInt32(nudProcessId.Value)] = AnalogyLogMessagePropertyName.ProcessId,
                [decimal.ToInt32(nudMachineName.Value)] = AnalogyLogMessagePropertyName.MachineName,
                [decimal.ToInt32(nudUserName.Value)] = AnalogyLogMessagePropertyName.User,
                [decimal.ToInt32(nudFileName.Value)] = AnalogyLogMessagePropertyName.FileName,
                [decimal.ToInt32(nudMethodName.Value)] = AnalogyLogMessagePropertyName.MethodName,
                [decimal.ToInt32(nudLineNumber.Value)] = AnalogyLogMessagePropertyName.LineNumber,
            };
            return maps;
        }
    }
}