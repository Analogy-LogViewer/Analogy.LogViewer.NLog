using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analogy.Interfaces;

namespace Analogy.LogViewer.NLogProvider
{
    public static class ChangeLog
    {
        public static IEnumerable<AnalogyChangeLog> GetChangeLog()
        {
            yield return new AnalogyChangeLog("Parsing Setting are not loaded in the user setting windows (issue #8)", AnalogChangeLogType.Defect, "Lior Banai", new DateTime(2019, 12, 19));
            yield return new AnalogyChangeLog("Deserialization of settings fails (issue #5)", AnalogChangeLogType.Defect, "Lior Banai", new DateTime(2019, 12, 11));
            yield return new AnalogyChangeLog("NLog Data Provider: standalone release", AnalogChangeLogType.Improvement, "Lior Banai", new DateTime(2019, 11, 13));

        }
    }
}
