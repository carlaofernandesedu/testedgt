using System;
using NUnit.Framework;
using br.procon.si.UAT.Consumidor.NuTests.Pages;
using br.procon.si.UAT.Consumidor.NuTests.DTO;
using br.procon.si.UAT.Helpers;

namespace br.procon.si.UAT.Consumidor.NuTests.Tests
{
    [TestFixture]
    public class LoginPageTest : BaseUITest
    {
        #region Constantes

        private const string tituloPagina = "Autenticação - Sistema Integrado Procon";

        #endregion Constantes

        #region Membros

        private LoginPage page;
        private LoginDTO dto;

        #endregion Membros

        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        public override void Preparar(string testkey)
        {
            //dto = DTOHelper.ConverterPara<LoginDTO>(TestContext.DataRow);
        }

        #endregion "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        #region "Metodos Validacao Teste"

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\loginpagefp001.csv", "loginpagefp001#csv", DataAccessMethod.Sequential), TestCategory("Login"), TestMethod]
        //public void FP001_InformarDadosCorretos_RedirecionadoPaginaConsulta()
        //{
        //    Executar(Preparar, () => { Browser.ObterPagina<LoginPage>().Logar(dto.Email, dto.Senha); });
        //    Assert.AreEqual(new AtendimentoConsumidorPage().ObterPaginaUrl().ToLower(), Browser.ObterUrl().ToLower());
        //}
        [Category("Login")]
        [Test]
        public void TC003_LogarComUsuarioExistente()
        {
            bool resultado = false;
            Executar(null, () => { resultado = LoginPage.AcoesLogar.Sucesso == Browser.ObterPagina<LoginPage>().Logar("carlos21@gmail.com","123456"); });
            Assert.IsTrue(resultado);
        }

        #endregion "Metodos Validacao Teste"
    }

}