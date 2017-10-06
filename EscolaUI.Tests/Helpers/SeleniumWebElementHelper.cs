using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading;

namespace EscolaUI.Tests.Helpers
{
    public static class SeleniumWebElementHelper
    {
        public static string ObterTexto(this IWebElement element)
        {
            return element.Text;
        }

        public static string ObterValor(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string ObterTextoDropDownList(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static void PreencherCampo(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void PreencherCampo(this IWebElement element, long value)
        {
            SeleniumWebElementHelper.PreencherCampo(element, value.ToString());
        }

        public static void PreencherCampoEAguardar(this IWebElement element, string value, int milliseconds = 3000)
        {
            PreencherCampo(element, value);
            Thread.Sleep(milliseconds);
        }

        public static void Clicar(this IWebElement element)
        {
            element.Click();
        }

        public static void ClicarEAguardar(this IWebElement element, int milliseconds = 3000)
        {
            element.Click();
            Thread.Sleep(milliseconds);
        }

        public static void SelecionarItemDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
