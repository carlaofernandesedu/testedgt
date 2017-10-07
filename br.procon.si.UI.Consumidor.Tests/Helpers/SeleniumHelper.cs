using br.procon.si.UI.Consumidor.Tests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace br.procon.si.UI.Consumidor.Tests.Helpers
{
    public class SeleniumHelper : ISeleniumHelper
    {
        //TODO: Revisar uso ao aplicar mecanismo estatico para instancia
        /*
        public static IWebDriver Cb;
        public WebDriverWait Wait;
        private static SeleniumHelper _instance;
        private SeleniumHelper _instance;
        */
        public IWebDriver Cb;
        public WebDriverWait Wait;

        public static SeleniumHelper Instance()
        {
            //TODO: Revisar uso ao aplicar mecanismo estatico para instancia
            //return _instance ?? (_instance = new SeleniumHelper());
            return new SeleniumHelper();
        }

        protected SeleniumHelper()
        {
            Cb = FabricarDriver(ConfigurationHelper.NomeDriver);
            Wait = new WebDriverWait(Cb, TimeSpan.FromSeconds(ConfigurationHelper.TempoDeEsperaCargaWebDriverWait));
        }

        private static IWebDriver FabricarDriver(string driver)
        {
            IWebDriver retorno = null;
            switch (driver.ToLower())
            {
                case "chrome":
                    //retorno = new ChromeDriver(ConfigurationHelper.ChromeDrive);
                    retorno = new ChromeDriver();
                    break;

                case "firefox":
                    //retorno = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(ConfigurationHelper.FirefoxDriver));
                    retorno = new FirefoxDriver();
                    break;
            }
            return retorno;
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

        public void ExecutarScripts(string javascript)
        {
            ((IJavaScriptExecutor)Cb).ExecuteScript(javascript);
        }

        public string ObterUrl()
        {
            return Cb.Url;
        }

        public bool ValidarConteudoUrl(string conteudo)
        {
            return Wait.Until(ExpectedConditions.UrlContains(conteudo));
        }

        public string NavegarPara(string url)
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

        public void InicializarElementos(object pagina)
        {
            PageFactory.InitElements(Cb, pagina);
        }

        public ISeleniumHelper PreencherValorNoElemento(string idCampo, string valorCampo)
        {
            var campo = Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(idCampo)));
            campo.SendKeys(valorCampo);
            return this;
        }

        public string ObterTextoDoElementoPorClasse(string className)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className))).Text;
        }

        public string ObterTextoDoElementoPorId(string id)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(id))).Text;
        }

        public string ObterTextoDoElementoPorXPath(string xpath)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath))).Text;
        }

        public T ObterPagina<T>(bool limparCookies = false, bool maximizado = true)
            where T : BasePage, new()
        {
            var pagina = new T();

            if (pagina.ObterPaginaUrl() == null)
            {
                throw new InvalidOperationException("Não foi possivel encontrar a url da Pagina.");
            }
            pagina.DefinirDriver(this);
            LimparCookies(limparCookies);
            NavegarPara(pagina.ObterPaginaUrl().AbsoluteUri);
            Maximizar(maximizado);
            pagina.InicializarElementos();
            return pagina;
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

        public void CapturarTela(string nomeArquivo)
        {
            var screenshot = ((ITakesScreenshot)Cb).GetScreenshot();
            SalvarScreenShot(screenshot, string.Format("{0}_" + nomeArquivo + ".png", DateTime.Now.ToFileTime()));
        }

        private static void SalvarScreenShot(Screenshot screenshot, string fileName)
        {
            var pathFile = Path.Combine(ConfigurationHelper.CaminhoPastaImagens, fileName);
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

        public void LimparCookies(bool isOk = true)
        {
            if (isOk)
                Cb.Manage().Cookies.DeleteAllCookies();
        }

        public string ObterTitulo()
        {
            return Cb.Title;
        }

        public ISeleniumHelper EsperarProcessamento(int segundos)
        {
            if (segundos > 0)
                Thread.Sleep(segundos / 1000);
            return this;
        }
    }
}