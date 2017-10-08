using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class LoginPageTest : BaseUITest
    {
        #region Membros
        private LoginPage page;
        #endregion
        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"
        private void ObterPagina()
        {
            page = Browser.ObterPagina<LoginPage>();
        }

        private void Logar()
        {
            page.Logar("carlo31@gmail.com", "123456");
        }
        #endregion
        #region "Metodos Validacao Teste"
        [TestMethod]
        public void LoginPage_FP_InformarDadosCorretos_RedirecionadoPaginaConsulta()
        {
            Executar(ObterPagina, Logar);
            Assert.AreEqual(1, 1);
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