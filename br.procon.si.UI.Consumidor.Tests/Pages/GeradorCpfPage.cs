using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static br.procon.si.UI.Consumidor.Tests.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class GeradorCpfPage : BasePage
    {
        #region "Constantes"

        private const int tempoEspera = 3000;
        private const string paginaUrl = "https://www.geradordecpf.org/";

        #endregion "Constantes"

        #region "Elementos Pagina por Selenium"

        [FindsBy(How = How.Id, Using = "btn-gerar-cpf")]
        private IWebElement _btGerarCpf;

        [FindsBy(How = How.Id, Using = "numero")]
        private IWebElement _CampoCpf;

        #endregion "Elementos Pagina por Selenium"

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper BtGerarCpf { get { return ConverterElemento(_btGerarCpf); } private set { } }
        public ISeleniumWebElementHelper CampoCpf { get { return ConverterElemento(_CampoCpf); } private set { } }

        #endregion "Atributos Selenium Convertidos"

        public override string ObterPaginaUrl()
        {
            return new Uri(paginaUrl).AbsoluteUri;
        }

        public string GerarCPF()
        {
            BtGerarCpf.ClicarEAguardar(tempoEspera);
            return CampoCpf.ObterValor();
        }
    }
}