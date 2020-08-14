using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;

namespace Analogy.LogViewer.NLogProvider
{
    internal class NLogFileParser
    {
        private readonly ISplitterLogParserSettings _logFileSettings;
        public readonly string[] splitters;
        public static string[] SplitterValues { get; } = { "#*#" };

        public NLogFileParser(ISplitterLogParserSettings logFileSettings)
        {
            _logFileSettings = logFileSettings;
            splitters = _logFileSettings.Splitter.Split(SplitterValues, StringSplitOptions.None);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AnalogyLogMessage Parse(string line)
        {
            var items = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<(AnalogyLogMessagePropertyName, string)> map = new List<(AnalogyLogMessagePropertyName, string)>();
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                if (_logFileSettings.Maps.ContainsKey(i))
                {
                    map.Add((_logFileSettings.Maps[i], items[i]));
                }
            }
            return AnalogyLogMessage.Parse(map);
        }
    }
}
