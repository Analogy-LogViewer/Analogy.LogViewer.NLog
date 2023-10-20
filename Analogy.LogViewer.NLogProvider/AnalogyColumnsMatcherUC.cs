using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;

namespace Analogy.LogViewer.NLogProvider
{
    public partial class AnalogyColumnsMatcherUC : UserControl
    {
        public Dictionary<int, AnalogyLogMessagePropertyName> Mapping => GetMapping();
        public AnalogyColumnsMatcherUC()
        {
            InitializeComponent();
        }

        public void LoadMapping(ISplitterLogParserSettings parser)
        {
        }
        private Dictionary<int, AnalogyLogMessagePropertyName> GetMapping()
        {
            Dictionary<int, AnalogyLogMessagePropertyName> maps = new(11)
            {
                { 1, AnalogyLogMessagePropertyName.Date }, 
                { 2, AnalogyLogMessagePropertyName.Level },
                { 3, AnalogyLogMessagePropertyName.Text },
                { 4, AnalogyLogMessagePropertyName.Source },
                { 5, AnalogyLogMessagePropertyName.Module },
                { 6, AnalogyLogMessagePropertyName.ProcessId },
                { 7, AnalogyLogMessagePropertyName.MachineName },
                { 8, AnalogyLogMessagePropertyName.User },
                { 9, AnalogyLogMessagePropertyName.FileName },
                { 10, AnalogyLogMessagePropertyName.MethodName },
                { 11, AnalogyLogMessagePropertyName.LineNumber },
            };

            return maps;
        }
    }
}
