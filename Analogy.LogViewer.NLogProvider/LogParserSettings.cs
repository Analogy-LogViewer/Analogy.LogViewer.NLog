using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.NLogProvider
{
    public class LogParserSettings: SplitterLogParserSettings
    {
        public string DateTimeFormat { get; set; } = "";
    }
}