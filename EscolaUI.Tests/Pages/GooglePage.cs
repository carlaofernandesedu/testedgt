using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaUI.Tests.Helpers;

namespace EscolaUI.Tests.Pages
{
    public class GooglePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.Name, Using = "btnG")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#rso a:nth-child(1)")]
        public IWebElement firstResult { get; set; }

        /// <summary>
        /// Query a search to Google's official page.
        /// </summary>
        /// <param name="text">The text to be searched.</param>
        public void Pesquisar(string texto)
        {
            //txtSearch.PreencherCampo(texto);
            //btnSearch.ClicarEAguardar();
        }

        public override Uri ConstructUrl()
        {
            return new Uri("http://www.google.com");
        }
    }
}
