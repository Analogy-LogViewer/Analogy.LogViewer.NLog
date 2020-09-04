using Analogy.Interfaces.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Analogy.Interfaces;

namespace Analogy.LogViewer.NLogProvider.UnitTests
{
    [TestClass]
    public class ReflectionLoadingTests
    {
        [TestMethod]
        public void LoadAssemblyTest()
        {
            var factories = new List<IAnalogyFactory>();
            var assemblies = new List<(IAnalogyFactory Factory, Assembly Assembly)>();
            var dataProviderSettings = new List<IAnalogyDataProviderSettings>();

            string[] moduleIdFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory,
                @"*Analogy.Implementation.*.dll", SearchOption.TopDirectoryOnly).Union(
                Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory,
                    @"*Analogy.LogViewer.*.dll", SearchOption.TopDirectoryOnly)).ToArray();
            foreach (string aFile in moduleIdFiles.Where(a => !Path.GetFileName(a).Contains("UnitTest")))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(Path.GetFullPath(aFile));
                    Type[] types = assembly.GetTypes();
                    foreach (Type aType in types)
                    {
                        try
                        {
                            if (aType.GetInterface(nameof(IAnalogyFactory)) != null)
                            {
                                if (!(Activator.CreateInstance(aType) is IAnalogyFactory factory)) continue;
                                //if no exception in init then add to list
                                factories.Add(factory);
                                assemblies.Add((factory, assembly));

                            }

                            if (aType.GetInterface(nameof(IAnalogyDataProviderSettings)) != null)
                            {
                                if (!(Activator.CreateInstance(aType) is IAnalogyDataProviderSettings setting))
                                    continue;
                                dataProviderSettings.Add(setting);
                            }
                        }

                        catch (Exception e)
                        {
                            Assert.Fail("Error Loading: " + e);
                        }

                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    Assert.Fail("Error Loading: " + ex);
                }
                catch (Exception e)
                {
                    Assert.Fail("Error Loading: " + e);
                }
            }
            Assert.IsTrue(factories.Count == 1);
            Assert.IsTrue(dataProviderSettings.Count == 1);
            Assert.IsTrue(assemblies.Count == 1);
        }

    }
}
