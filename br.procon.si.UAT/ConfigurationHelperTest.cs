using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace br.procon.si.UAT
{
    [TestClass]
    public class ConfigurationHelperTest : BaseUITest
    {
        [TestMethod]
        public void TestJsonData()
        {
            var retorno = ConfigurationHelper.DataSourceConfigTest;
            Assert.IsNotNull(retorno);
        }

        [TestMethod]
        public void TestConnectionString()
        {
            var retorno = ConfigurationHelper.ObterConexaoBancoDeDados(string.Empty);
            Assert.IsNotNull(retorno);
        }

        [TestMethod]
        public void TestObterDadosDataSourceSQL()
        {
            var retorno = ObterDadosDoDataSource<SomaDTO>("teste001");
            Assert.IsNotNull(retorno);
        }

        [TestMethod]
        public void TestObterDadosDataSourceExcel()
        {
            var retorno = ObterDadosDoDataSource<SomaDTO>("teste002");
            Assert.IsNotNull(retorno);
        }

        public override void Preparar(string testeId)
        {
            throw new NotImplementedException();
        }
    }

    public class SomaDTO
    {
        public string testeId { get; set; }
        public int arg_um { get; set; }
        public int arg_dois { get; set; }
    }
}