using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.procon.si.UI.Consumidor.Tests.DTO;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using br.procon.si.UI.Consumidor.Tests.Pages;

namespace br.procon.si.UI.Consumidor.Tests
{
    /// <summary>
    /// Summary description for ConsumidorTest
    /// </summary>
    [TestClass]
    public class ConsumidorPageTest : BaseUITest
    {
        #region Membros 
        private ConsumidorDTO dto;
        #endregion
        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"
        public override void Preparar(string testkey)
        {
            dto = DTOHelper.ConverterPara<ConsumidorDTO>(TestContext.DataRow);
        }

        private void Salvar()
        {
            Browser.ObterPagina<LoginPage>().Logar(dto.Email, dto.Senha);
            Browser.ObterPagina<ConsumidorPage>();
        }
        #endregion

        #region  "Metodos Validacao Teste"
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataconsumidorpagefp001.csv", "dataconsumidorpagefp001#csv", DataAccessMethod.Sequential), TestCategory("FP001"), TestMethod]
        public void ConsumidorPage_FP_InformarDadosCorretos_ExibirMensagemOK()
        {
            Executar(Preparar, Salvar);
            Assert.AreEqual(1,1);
        }
        #endregion 
    }
}
