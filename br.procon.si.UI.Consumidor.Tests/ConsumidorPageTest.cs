using br.procon.si.UI.Consumidor.Tests.DTO;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        private string NovoCpf;

        #endregion Membros

        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        public override void Preparar(string testkey)
        {
            GerarCpf();
            dto = DTOHelper.ConverterPara<ConsumidorDTO>(TestContext.DataRow);
            dto.CPF = NovoCpf;
        }

        private void GerarCpf()
        {
            NovoCpf = Browser.ObterPagina<GeradorCpfPage>().GerarCPF();
        }

        private void Salvar()
        {
            Browser.ObterPagina<LoginPage>().Logar(dto.Email, dto.Senha);
            Browser.ObterPagina<ConsumidorPage>().Salvar(dto);
        }

        #endregion "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        #region "Metodos Validacao Teste"

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataconsumidorpagefp001.csv", "dataconsumidorpagefp001#csv", DataAccessMethod.Sequential), TestCategory("FP001"), TestMethod]
        public void ConsumidorPage_FP_InformarDadosCorretos_ExibirMensagemOK()
        {
            Executar(Preparar, Salvar);
            Assert.AreEqual(1, 1);
        }

        [TestCategory("FP001"), TestMethod]
        public void GeradorCpf_FP_ObterNovoCpf_RetornadoNovoCPF()
        {
            Executar(null, GerarCpf);
            Assert.IsFalse(String.IsNullOrEmpty(NovoCpf));
        }

        #endregion "Metodos Validacao Teste"
    }
}