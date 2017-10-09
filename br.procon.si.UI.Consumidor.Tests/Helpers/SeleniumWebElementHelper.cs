using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading;

namespace br.procon.si.UI.Consumidor.Tests.Helpers
{
    public class SeleniumWebElementHelper : ISeleniumWebElementHelper
    {
        private readonly IWebElement _elemento;

        public SeleniumWebElementHelper(IWebElement elemento)
        {
            _elemento = elemento;
        }

        public static ISeleniumWebElementHelper Converter(IWebElement elemento)
        {
            return new SeleniumWebElementHelper(elemento);
        }

        public string ObterTexto()
        {
            return _elemento.Text;
        }

        public string ObterValor()
        {
            return _elemento.GetAttribute("value");
        }

        public string ObterTextoDoDropDownList()
        {
            return new SelectElement(_elemento).AllSelectedOptions.SingleOrDefault().Text;
        }

        public SeleniumWebElementHelper PreencherCampo(string value)
        {
            _elemento.SendKeys(value);
            return this;
        }

        public SeleniumWebElementHelper PreencherCampo(long value)
        {
            return PreencherCampo(value.ToString());
        }

        public SeleniumWebElementHelper PreencherCampoEAguardar(string value, int milisegundos = 3000)
        {
            PreencherCampo(value);
            if (milisegundos > 0)
                Thread.Sleep(milisegundos);
            return this;
        }

        public SeleniumWebElementHelper Clicar()
        {
            _elemento.Click();
            return this;
        }

        public SeleniumWebElementHelper ClicarEAguardar(int miliSegundos = 3000)
        {
            _elemento.Click();
            if (miliSegundos > 0)
                Thread.Sleep(miliSegundos);
            return this;
        }

        public SeleniumWebElementHelper SelecionarItemDropDown(string value)
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

        public static ISeleniumWebElementHelper ConverterElemento(IWebElement elemento)
        {
            return SeleniumWebElementHelper.Converter(elemento);
        }
    }
}