using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using static br.procon.si.UAT.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
{
    public partial class ConsumidorPage : BasePage
    {
        #region "Constantes"

        private const int tempoEspera = 5000;
        private const string paginaUrl = "/consumidor/criar";

        #endregion "Constantes"

        #region "Elementos Pagina por Selenium"

        [FindsBy(How = How.Id, Using = "Nome")]
        private IWebElement _nome;

        //[FindsBy(How = How.Id, Using = "Sexo")]
        //private List<IWebElement> _sexo;
        private const string _sexo = "Sexo";

        [FindsBy(How = How.Id, Using = "NomeSocial")]
        private IWebElement _nomeSocial;

        [FindsBy(How = How.Id, Using = "CPF")]
        private IWebElement _Cpf;

        [FindsBy(How = How.Id, Using = "RG")]
        private IWebElement _Rg;

        [FindsBy(How = How.Id, Using = "OrgaoEmissor")]
        private IWebElement _orgaoEmissor;

        [FindsBy(How = How.Id, Using = "OrgaoEmissorUF")]
        private IWebElement _orgaoEmissorUF;

        [FindsBy(How = How.Id, Using = "DataNascimento")]
        private IWebElement _dataNascimento;

        [FindsBy(How = How.Id, Using = "IdTipoDeficiencia")]
        private IWebElement _idTipoDeficiencia;

        [FindsBy(How = How.Id, Using = "OutroTipoDeficiencia")]
        private IWebElement _outroTipoDeficiencia;

        [FindsBy(How = How.Id, Using = "CEP")]
        private IWebElement _cep;

        [FindsBy(How = How.Id, Using = "Logradouro")]
        private IWebElement _logradouro;

        [FindsBy(How = How.Id, Using = "Numero")]
        private IWebElement _numero;

        [FindsBy(How = How.Id, Using = "Cidade")]
        private IWebElement _cidade;

        [FindsBy(How = How.Id, Using = "Estado")]
        private IWebElement _estado;

        [FindsBy(How = How.Id, Using = "Telefone")]
        private IWebElement _telefone;

        [FindsBy(How = How.Id, Using = "Celular")]
        private IWebElement _celular;

        [FindsBy(How = How.Id, Using = "Preferencias_TipoNotificacao")]
        private IWebElement _preferencias_TipoNotificacao;

        [FindsBy(How = How.Name, Using = "deficiencia")]
        private IWebElement _chkDeficiencia;

        [FindsBy(How = How.Id, Using = "Bairro")]
        private IWebElement _bairro;

        [FindsBy(How = How.Id, Using = "Complemento")]
        private IWebElement _complemento;

        [FindsBy(How = How.Id, Using = "btnSalvar")]
        private IWebElement _btnSalvar;

        #endregion "Elementos Pagina por Selenium"

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper Nome { get { return ConverterElemento(_nome); } private set { } }
        public List<ISeleniumWebElementHelper> Sexo { get { return Driver.ObterElementosPorNome(_sexo); } private set { } }
        public ISeleniumWebElementHelper NomeSocial { get { return ConverterElemento(_nomeSocial); } private set { } }
        public ISeleniumWebElementHelper CPF { get { return ConverterElemento(_Cpf); } private set { } }
        public ISeleniumWebElementHelper RG { get { return ConverterElemento(_Rg); } private set { } }
        public ISeleniumWebElementHelper OrgaoEmissorUF { get { return ConverterElemento(_orgaoEmissorUF); } private set { } }
        public ISeleniumWebElementHelper OrgaoEmissor { get { return ConverterElemento(_orgaoEmissor); } private set { } }
        public ISeleniumWebElementHelper DataNascimento { get { return ConverterElemento(_dataNascimento); } private set { } }
        public ISeleniumWebElementHelper ChkDeficiencia { get { return ConverterElemento(_chkDeficiencia); } private set { } }
        public ISeleniumWebElementHelper IdTipoDeficiencia { get { return ConverterElemento(_idTipoDeficiencia); } private set { } }
        public ISeleniumWebElementHelper OutroTipoDeficiencia { get { return ConverterElemento(_outroTipoDeficiencia); } private set { } }
        public ISeleniumWebElementHelper CEP { get { return ConverterElemento(_cep); } private set { } }
        public ISeleniumWebElementHelper Logradouro { get { return ConverterElemento(_logradouro); } private set { } }
        public ISeleniumWebElementHelper Numero { get { return ConverterElemento(_numero); } private set { } }
        public ISeleniumWebElementHelper Bairro { get { return ConverterElemento(_bairro); } private set { } }
        public ISeleniumWebElementHelper Complemento { get { return ConverterElemento(_complemento); } private set { } }
        public ISeleniumWebElementHelper Cidade { get { return ConverterElemento(_cidade); } private set { } }
        public ISeleniumWebElementHelper Estado { get { return ConverterElemento(_estado); } private set { } }
        public ISeleniumWebElementHelper Telefone { get { return ConverterElemento(_telefone); } private set { } }
        public ISeleniumWebElementHelper Celular { get { return ConverterElemento(_celular); } private set { } }
        public ISeleniumWebElementHelper Preferencias_TipoNotificacao { get { return ConverterElemento(_preferencias_TipoNotificacao); } private set { } }
        public ISeleniumWebElementHelper BtnSalvar { get { return ConverterElemento(_btnSalvar); } private set { } }

        #endregion "Atributos Selenium Convertidos"
 
    }
}