using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.procon.si.UAT.Helpers;

namespace br.procon.si.UAT
{
    [TestClass]
    public class ConfigurationHelperTest
    {
        [TestMethod]
        public void TestJsonData()
        {
            var retorno = ConfigurationHelper.DataSourceTest;
            Assert.IsNotNull(retorno);
        }
    }
}
