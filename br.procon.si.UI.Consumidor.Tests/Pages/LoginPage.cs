﻿using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static br.procon.si.UI.Consumidor.Tests.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class LoginPage : BasePage
    {
        #region "Constantes"
        private const int TempoEsperaLogin = 3000;
        #endregion
        #region "Membros Selenium"

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _email;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement _password;
        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-success")]
        private IWebElement _btnSubmit;

        #endregion "Membros Selenium"

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper Email { get { return ConverterElemento(_email); } private set { } }
        public ISeleniumWebElementHelper Password { get { return ConverterElemento(_password); } private set { } }
        public ISeleniumWebElementHelper BtnSubmit { get { return ConverterElemento(_btnSubmit); } private set { } }

        #endregion "Atributos Selenium Convertidos"

        public LoginPage()
        {
        }

        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + "/login").AbsoluteUri;
        }

        public void Logar(string usuario, string senha)
        {
            Email.PreencherCampo(usuario);
            Password.PreencherCampo(senha);
            BtnSubmit.ClicarEAguardar(TempoEsperaLogin);
        }
    }
}