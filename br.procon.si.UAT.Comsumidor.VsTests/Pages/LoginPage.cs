using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static br.procon.si.UAT.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UAT.Consumidor.VsTests.Pages
{
    public partial class LoginPage : BasePage
    {
        #region "Constantes"

        private const int tempoEspera = 3000;
        private const string paginaUrl = "/login";

        #endregion "Constantes"

        #region "Elementos Pagina por Selenium"

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _email;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement _password;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-success")]
        private IWebElement _btnSubmit;

        #endregion "Elementos Pagina por Selenium"

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper Email { get { return ConverterElemento(_email); } private set { } }
        public ISeleniumWebElementHelper Password { get { return ConverterElemento(_password); } private set { } }
        public ISeleniumWebElementHelper BtnSubmit { get { return ConverterElemento(_btnSubmit); } private set { } }

        #endregion "Atributos Selenium Convertidos"

    }
}