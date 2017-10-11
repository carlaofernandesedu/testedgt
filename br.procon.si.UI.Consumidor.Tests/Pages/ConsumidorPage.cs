using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.DTO;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using static br.procon.si.UI.Consumidor.Tests.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class ConsumidorPage : BasePage
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

        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + paginaUrl).AbsoluteUri;
        }

        public void Salvar(ConsumidorDTO dto)
        {
            if (!String.IsNullOrWhiteSpace(dto.Nome)) Nome.Limpar().PreencherCampo(dto.Nome);
            if (dto.Sexo > 0) Sexo.Find(el => el.ObterValor() == dto.Sexo.ToString()).Clicar();
            if (!String.IsNullOrWhiteSpace(dto.NomeSocial)) NomeSocial.PreencherCampo(dto.NomeSocial);
            if (!String.IsNullOrWhiteSpace(dto.DataNascimento)) DataNascimento.PreencherCampo(dto.DataNascimento);
            if (!String.IsNullOrWhiteSpace(dto.CPF)) CPF.PreencherCampo(dto.CPF);
            if (!String.IsNullOrWhiteSpace(dto.RG)) RG.PreencherCampo(dto.RG);
            if (!String.IsNullOrWhiteSpace(dto.OrgaoEmissorUF)) OrgaoEmissorUF.SelecionarItemDropDown(dto.OrgaoEmissorUF);
            if (!String.IsNullOrWhiteSpace(dto.OrgaoEmissor)) OrgaoEmissor.PreencherCampo(dto.OrgaoEmissor);
            if (dto.TemDeficiencia)
            {
                ChkDeficiencia.PreencherCampo(1);
                if (!String.IsNullOrWhiteSpace(dto.IdTipoDeficiencia)) IdTipoDeficiencia.PreencherCampo(dto.IdTipoDeficiencia);
                if (!String.IsNullOrWhiteSpace(dto.OutroTipoDeficiencia)) OutroTipoDeficiencia.PreencherCampo(dto.OutroTipoDeficiencia);
            }
            if (!String.IsNullOrWhiteSpace(dto.CEP))
            {
                CEP.PreencherCampo(dto.CEP);
                Complemento.ClicarEAguardar(tempoEspera);
            }
            if (!String.IsNullOrWhiteSpace(dto.Logradouro)) Logradouro.PreencherCampo(dto.Logradouro);
            if (!String.IsNullOrWhiteSpace(dto.Numero)) Numero.PreencherCampo(dto.Numero);
            if (!String.IsNullOrWhiteSpace(dto.Cidade)) Cidade.PreencherCampo(dto.Cidade);
            if (!String.IsNullOrWhiteSpace(dto.Estado)) Estado.PreencherCampo(dto.Estado);
            if (!String.IsNullOrWhiteSpace(dto.Telefone)) Telefone.PreencherCampo(dto.Telefone);
            if (!String.IsNullOrWhiteSpace(dto.Celular)) Celular.PreencherCampo(dto.Celular);
            if (!String.IsNullOrWhiteSpace(dto.Preferencias_TipoNotificacao)) Preferencias_TipoNotificacao.PreencherCampo(dto.Preferencias_TipoNotificacao);
            CapturarTela();
            BtnSalvar.Clicar();
        }
    }
}