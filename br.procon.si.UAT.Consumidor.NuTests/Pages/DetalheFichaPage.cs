using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using static br.procon.si.UAT.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
{
    public partial class DetalheFichaPage : BasePage
    {
        #region "Constantes"

        private const int tempoEspera = 3000;
        private const string paginaUrl = "/login";

        private const string xpathProtocolo = "//div[@id='content']/div[2]/div/div/div/div/div/p";
        private const string xpathDataSolicitacao = "//div[@id='content']/div[2]/div/div/div/div/div[2]/p";
        private const string xpathStatus = "//div[@id='content']/div[2]/div/div/div/div/div[3]/p";
        private const string xpathPrazoAtendimento = "//div[@id='content']/div[2]/div/div/div/div/div[4]/p";
        private const string xpathClassificacao = "//div[@id='content']/div[2]/div/div/div/div[2]/div/p";
        #endregion "Constantes"

        #region "Elementos Pagina por Selenium Identificacao"

        [FindsBy(How = How.XPath, Using = xpathProtocolo)]
        private IWebElement _protocolo;
        [FindsBy(How = How.XPath, Using = xpathDataSolicitacao)]
        private IWebElement _dataSolicitacao;
        [FindsBy(How = How.XPath, Using = xpathStatus)]
        private IWebElement _status;
        [FindsBy(How = How.XPath, Using = xpathPrazoAtendimento)]
        private IWebElement _prazoAtendimento;
        [FindsBy(How = How.XPath, Using = xpathClassificacao)]
        private IWebElement _classificacao;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _razaoSocial;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _numeroDocumento;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _nomeFantasia;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _website;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _telefone;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _email;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _cep;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _logradouro;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _numero;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _complemento;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _bairro;
        //[FindsBy(How = How.XPath, Using = "Email")]
        //private IWebElement _cidade;
        //[FindsBy(How = How.XPath, Using = "Email")]
        #endregion

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper Protocolo { get { return ConverterElemento(_protocolo); } private set { } }
        public ISeleniumWebElementHelper DataSolicitacao { get { return ConverterElemento(_dataSolicitacao); } private set { } }
        public ISeleniumWebElementHelper Status { get { return ConverterElemento(_status); } private set { } }
        public ISeleniumWebElementHelper PrazoAtendimento { get { return ConverterElemento(_prazoAtendimento); } private set { } }
        public ISeleniumWebElementHelper Classificacao { get { return ConverterElemento(_classificacao); } private set { } }


        public override string ObterPaginaUrl()
        {
            throw new System.NotImplementedException();
        }

        #endregion "Atributos Selenium Convertidos"


    }
}