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
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }


        public LoginPage()  
        {
            baseURL = ConfigurationHelper.LoginUrl;
            Browser.NavegarParaSite(baseURL);
            InicializarElementos(this);
        }
        
    }
    
}
