using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscolaUI.Tests.Pages;

namespace EscolaUI.Tests
{
    [TestClass]
    public class UnitTest1 : BaseUITest
    {
        //[TestCategory("Interface"), TestCategory("Aluno"), TestCategory("Unitario"), TestMethod]
        public void Google_Validar_Acesso_Pagina()
        {
            //string searchText = "Blog netcoders";
            //string expectedTitle = ".NET Coders | Um dos maiores e mais ativos grupos de ...";
            GooglePage gPage = new GooglePage();
            gPage.ObterScreenShot("page01");
            //gPage.Search(searchText);
            var expectedTitle = "Google";
            Assert.AreEqual(expectedTitle, gPage.Titulo);
        }

        [TestCategory("Interface"), TestCategory("Aluno"), TestCategory("Unitario"), TestMethod]
        public void Consumidor_Validar_Acesso_Pagina()
        {

            LoginPage loginPage = new LoginPage();
            //loginPage.Browser.PreencherTextBox("Email", "carlos@31");
            //loginPage.Browser.PreencherTextBox("Password", "123456");
            loginPage.Email.SendKeys("carlos@31");
            loginPage.Password.SendKeys("123456");
            
            Assert.AreEqual(true, true);
        }

    }
}
