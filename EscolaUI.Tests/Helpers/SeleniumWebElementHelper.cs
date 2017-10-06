using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading;

namespace EscolaUI.Tests.Helpers
{
    public class SeleniumWebElementHelper
    {
        private readonly IWebElement  _elemento; 
        public SeleniumWebElementHelper(IWebElement elemento)
        {
            _elemento = elemento; 
        }
        public string ObterTexto()
        {
            return _elemento.Text;
        }

        public string ObterValor()
        {
            return _elemento.GetAttribute("value");
        }

        public string ObterTextoDropDownList()
        {
            return new SelectElement(_elemento).AllSelectedOptions.SingleOrDefault().Text;
        }

        public SeleniumWebElementHelper PreencherCampo( string value)
        {
            _elemento.SendKeys(value);
            return this;
        }

        public SeleniumWebElementHelper PreencherCampo(long value)
        {
            return PreencherCampo(value.ToString());
        }

        public  SeleniumWebElementHelper PreencherCampoEAguardar(string value, int milliseconds = 3000)
        {
            PreencherCampo(value);
            Thread.Sleep(milliseconds);
            return this;
        }

        public SeleniumWebElementHelper Clicar()
        {
            _elemento.Click();
            return this;
        }

        public SeleniumWebElementHelper ClicarEAguardar(int milliseconds = 3000)
        {
            _elemento.Click();
            Thread.Sleep(milliseconds);
            return this;
        }

        public SeleniumWebElementHelper SelecionarItemDropDown( string value)
        {
            new SelectElement(_elemento).SelectByText(value);
            return this;
        }

        public SeleniumWebElementHelper Limpar()
        {
            _elemento.Clear();
            return this; 
        }


        public SeleniumWebElementHelper Submit()
        {
            _elemento.Submit();
            return this;
        }
    }
}
