using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static br.procon.si.UI.Consumidor.Tests.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class ConsumidorPage : BasePage
    {
        #region "Constantes"
        private const int TempoEsperaLogin = 3000;
        #endregion

        #region "Membros Selenium"
        [FindsBy(How = How.Id, Using = "IdMunicipio")]
        private IWebElement _idMunicipio;
        [FindsBy(How = How.Id, Using = "Nome")]
        private IWebElement _nome;
        [FindsBy(How = How.Id, Using = "Sexo")]
        private IWebElement _sexo;

        #endregion "Membros Selenium"

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper IdMunicipio { get { return ConverterElemento(_idMunicipio); } private set { } }
        public ISeleniumWebElementHelper Nome { get { return ConverterElemento(_nome); } private set { } }
        public ISeleniumWebElementHelper Sexo { get { return ConverterElemento(_sexo); } private set { } }

        #endregion "Atributos Selenium Convertidos"
        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + "/consumidor/criar").AbsoluteUri;
        }

        public void Salvar(object dto)
        {

        }
    }
}
