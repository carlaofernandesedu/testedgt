using br.procon.si.UI.Consumidor.Tests.Helpers;
using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class LoginPageTest : BaseUITest
    {
        #region Membros
        private LoginPage page;
        private string email;
        private string password;
        #endregion
        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"
        private void ObterPagina()
        {
            page = Browser.ObterPagina<LoginPage>();
        }

        private void PrepararAcessoDadosCorretos()
        {
            ObterPagina();
            email = "carlos21@gmail.com";
            password = "123456";
        }

        private void Logar()
        {
            page.Logar(email,password);
        }
        #endregion
        #region "Metodos Validacao Teste"
        [TestMethod]
        public void LoginPage_FP_InformarDadosCorretos_RedirecionadoPaginaConsulta()
        {
            Executar(PrepararAcessoDadosCorretos, Logar);
            var url = ConfigurationHelper.SiteUrl + "/atendimentoconsumidor";
            Assert.AreEqual(url, Browser.ObterUrl());
        }

        [TestMethod]
        public void LoginPage_FP_InformarUrlPagina_PaginaCarregada()
        {
            Executar(null, ObterPagina);
            Assert.AreEqual("Autenticação - Sistema Integrado Procon", page.Titulo);
        }
        #endregion
    }
}