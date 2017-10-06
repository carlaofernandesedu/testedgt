using EscolaUI.Tests.Helpers;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaUI.Tests.Pages
{
    public class LoginPage : BasePage 
    {
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _Email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement _Password { get; set; }

        public SeleniumWebElementHelper Email
        {
            get
            {
                return new SeleniumWebElementHelper(_Email);
            }
        }

        public SeleniumWebElementHelper Password 
        {
            get
            {
                return new SeleniumWebElementHelper(_Password);
            }
        }



        public LoginPage()  
        {
        }

        public override Uri ConstructUrl()
        {
            return new Uri("http://consumidordes.prodesp.sp.gov.br/Login");
        }
    }
    
}
