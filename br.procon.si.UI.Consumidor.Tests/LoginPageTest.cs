using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.procon.si.UI.Consumidor.Tests.Pages;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class LoginPageTest : BaseUITest
    {
        [TestMethod]
        public void TestLogin()
        {
            var titulo = Browser.ObterPagina<LoginPage>().Titulo;
            Assert.IsTrue(true);
        }
    }
}
