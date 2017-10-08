using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static br.procon.si.UI.Consumidor.Tests.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class LoginPage : BasePage
    {
        #region "Membros Selenium"

        [FindsBy(How = How.Id, Using = nameof(Email))]
        private IWebElement _email;
        [FindsBy(How = How.Id, Using = nameof(Password))]
        private IWebElement _password;
        [FindsBy(How = How.ClassName, Using = "btn btn - success")]
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

        public override Uri ObterPaginaUrl()
        {
            return new Uri("http://consumidor.homologacao.sp.gov.br/Login");
        }

        public void Logar(string usuario, string senha)
        {
            Email.PreencherCampo(usuario);
            Password.PreencherCampo(senha);
            Driver.EsperarProcessamento(1000);
            //ConverterElemento(_btnSubmit).Clicar();
        }
    }
}