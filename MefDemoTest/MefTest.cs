using System.ComponentModel.Composition;
using System.Linq;
using MefDemo.Contracts;
using MefDemo.ImportLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MefDemoTest
{
    [TestClass]
    public class MefTest
    {
        [TestMethod]
        public void when_import_the_find_export_libs()
        {
            var importer = new Importer();
            importer.DoImport();
            Assert.IsTrue(importer.Services.Count() == 2);
        }
    }

    #region export_test_libs

    [Export(typeof (IService))]
    public class FakeService : IService
    {
        public string Description => @"Fake Service";

        public int Opertation(int a, int b)
        {
            return a > b ? a : b;
        }
    }

    [Export(typeof (IService))]
    public class AnotherFakeService : IService
    {
        public string Description => @"Another Fake Service";

        public int Opertation(int a, int b)
        {
            return a*a + b*b;
        }
    }

    #endregion
}