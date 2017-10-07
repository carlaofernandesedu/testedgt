using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = nameof(Email))]
        private IWebElement _Email { get; set; }

        [FindsBy(How = How.Id, Using = nameof(Password))]
        private IWebElement _Password { get; set; }

        public ISeleniumWebElementHelper Email
        {
            get
            {
                return new SeleniumWebElementHelper(_Email);
            }
        }

        public ISeleniumWebElementHelper Password
        {
            get
            {
                return new SeleniumWebElementHelper(_Password);
            }
        }

        public LoginPage()
        {
        }

        public override Uri ObterPaginaUrl()
        {
            return new Uri("http://consumidordes.prodesp.sp.gov.br/Login");
        }
    }
}