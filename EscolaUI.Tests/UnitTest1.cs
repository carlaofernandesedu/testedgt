using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscolaUI.Tests.Pages;

namespace EscolaUI.Tests
{
    [TestClass]
    public class UnitTest1 : BaseUI2Test
    {
        [TestCategory("Interface"), TestCategory("Aluno"), TestCategory("Unitario"), TestMethod]
        public void Google_Validar_Acesso_Pagina()
        {
            //string searchText = "Blog netcoders";
            //string expectedTitle = ".NET Coders | Um dos maiores e mais ativos grupos de ...";
            //GooglePage gPage = new GooglePage();
            //gPage.ObterScreenShot("page01");
            ////gPage.Search(searchText);
            //var expectedTitle = "Google";
            //Assert.AreEqual(expectedTitle, gPage.Titulo);
            var page = Browser.ObterPagina<GooglePage>();
            var expectedTitle = "Google";
            Assert.AreEqual(expectedTitle, page.Titulo);


        }

        [TestCategory("Interface"), TestCategory("Aluno"), TestCategory("Unitario"), TestMethod]
        public void Consumidor_Validar_Acesso_Pagina()
        {

            LoginPage page = Browser.ObterPagina<LoginPage>();
            //LoginPage page = new LoginPage();
            //page.DefinirDriver(Browser);
            //Browser.NavegarParaSite(page.ConstructUrl().AbsoluteUri);
            //Browser.InicializarElementos(page);
            //loginPage.Browser.PreencherTextBox("Email", "carlos@31");
            //loginPage.Browser.PreencherTextBox("Password", "123456");
            page.Email.SendKeys("carlos@31");
            page.Password.SendKeys("123456");
            Assert.AreEqual(true, true);
        }

    }
}
