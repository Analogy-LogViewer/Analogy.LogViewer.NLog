using Analogy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.NLogProvider
{
    public static class ChangeLog
    {
        public static IEnumerable<AnalogyChangeLog> GetChangeLog()
        {
            yield return new AnalogyChangeLog("Populate RawText Field #139", AnalogChangeLogType.Improvement, "Lior Banai", new DateTime(2023, 10, 20), "5.0.3.1");
            yield return new AnalogyChangeLog("Support MSIX mode #138", AnalogChangeLogType.Improvement, "Lior Banai", new DateTime(2023, 10, 20), "5.0.3.1");
            yield return new AnalogyChangeLog("Update Nuget with Interface Nuget changes #137", AnalogChangeLogType.Improvement, "Lior Banai", new DateTime(2023, 10, 20), "5.0.3.1");
            yield return new AnalogyChangeLog("Add Source Link To Project (issue #9)", AnalogChangeLogType.Improvement, "Lior Banai", new DateTime(2020, 01, 05), "");
            yield return new AnalogyChangeLog("Parsing Setting are not loaded in the user setting windows (issue #8)", AnalogChangeLogType.Bug, "Lior Banai", new DateTime(2019, 12, 19), "");
            yield return new AnalogyChangeLog("Deserialization of settings fails (issue #5)", AnalogChangeLogType.Bug, "Lior Banai", new DateTime(2019, 12, 11), "");
            yield return new AnalogyChangeLog("NLog Data Provider: standalone release", AnalogChangeLogType.Improvement, "Lior Banai", new DateTime(2019, 11, 13), "");
        }
    }
}