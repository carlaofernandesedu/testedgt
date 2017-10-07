using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class LoginPageTest : BaseUITest
    {
        private LoginPage page;

        protected override void Preparar()
        {
            var page = Browser.ObterPagina<LoginPage>();
        }

        protected override void Executar()
        {
            // page.Logar();
        }

        [TestMethod]
        public void LoginPage_Logar_CarregouPagina()
        {
            Assert.IsTrue(true);
        }
    }
}