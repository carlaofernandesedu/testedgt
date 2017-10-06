using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.IO;
using System.Threading;

namespace EscolaUI.Tests.Helpers
{
    public class SeleniumHelper : ISeleniumHelper
    {
        public static IWebDriver Cb;
        public WebDriverWait Wait;

        private static SeleniumHelper _instance;
        public static SeleniumHelper Instance()
        {
            return _instance ?? (_instance = new SeleniumHelper());
        }

        protected SeleniumHelper()
        {
            Cb = FabricarDriver(ConfigurationHelper.BrowserType);
            Wait = new WebDriverWait(Cb, TimeSpan.FromSeconds(30));
        }

        private static IWebDriver FabricarDriver(int tipo)
        {
            IWebDriver retorno = null;
            switch (tipo)
            {
                case 1:
                    //retorno = new ChromeDriver(ConfigurationHelper.ChromeDrive);
                    retorno = new ChromeDriver();
                    break;
                case 2:
                    //retorno = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(ConfigurationHelper.FirefoxDriver));
                    retorno = new FirefoxDriver();
                    break;
            }
            return retorno;
        }

        public void InicializarElementos(object page)
        {
            PageFactory.InitElements(Cb, page);
        }

        public void AguardarCarregarPagina(int segundos)
        {
            //Cb.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(segundos));
            Cb.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(segundos);
        }

        public void AguardarExecucaoScripts(int segundos)
        {
            //Cb.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(segundos));
            Cb.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(segundos);
        }

        public string ObterUrl()
        {
            return Cb.Url;
        }

        public bool ValidarConteudoUrl(string conteudo)
        {
            return Wait.Until(ExpectedConditions.UrlContains(conteudo));
        }

        public string NavegarParaSite(string url)
        {
            Cb.Navigate().GoToUrl(url);
            return ObterUrl();
        }

        public void ClicarLinkSite(string linkText)
        {
            var link = Wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(linkText)));
            link.Click();
        }

        public void ClicarBotaoSite(string botaoId)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(botaoId))).Click();
        }
        public void PreencherTextBox(string idCampo, string valorCampo)
        {
            var campo = Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(idCampo)));
            campo.SendKeys(valorCampo);
        }


        public string ObterTextoPorClasse(string className)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className))).Text;
        }

        public string ObterTextoPorId(string id)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(id))).Text;
        }

        public string ObterTextoPorXPath(string xpath)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath))).Text;
        }

        public IEnumerable<IWebElement> ObterElementosPorClasse(string className)
        {
            return Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName(className)));
        }

        public IWebElement ObterElementoPorId(string id)
        {
            return Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id(id))).FirstOrDefault();
        }

        public IWebElement ObterElementoPorNome(string nome)
        {
            return Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Name(nome))).FirstOrDefault();
        }

        public void ObterScreenShot(string nome)
        {
            var screenshot = ((ITakesScreenshot)Cb).GetScreenshot();
            SalvarScreenShot(screenshot, string.Format("{0}_" + nome + ".png", DateTime.Now.ToFileTime()));
        }

        private static void SalvarScreenShot(Screenshot screenshot, string fileName)
        {
            var pathFile = Path.Combine(ConfigurationHelper.FolderPicture, fileName);
            screenshot.SaveAsFile(pathFile, ScreenshotImageFormat.Png);
        }

        public void Fechar()
        {
            Cb.Close();
            Cb.Quit();
        }

        public void Maximizar(bool isOk = true)
        {
            if (isOk)
                Cb.Manage().Window.Maximize();
        }

        public void ExecutarScripts(string javascript)
        {
            ((IJavaScriptExecutor)Cb).ExecuteScript(javascript);
        }

        public void LimparCookies(bool isOk = true)
        {
            if (isOk)
                Cb.Manage().Cookies.DeleteAllCookies();
        }

        public string ObterTitulo()
        {
            return Cb.Title;
        }

        public void Esperar(int segundos)
        {
            Thread.Sleep(segundos/1000);
        }
    }
}
