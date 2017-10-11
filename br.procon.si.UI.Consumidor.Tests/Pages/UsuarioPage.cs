using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using static br.procon.si.UI.Consumidor.Tests.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public class UsuarioPage : BasePage
    {
        #region Membros

        private string paginaUrl = "/login/criarusuario";
        private const int tempoEspera = 5000;

        #endregion Membros

        #region "Elementos Selenium"

        [FindsBy(How = How.Id, Using = "Nome")]
        private IWebElement _nome;

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _email;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "btnCadastrar")]
        private IWebElement _btnSubmit;

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        private IWebElement _confirmPassword;

        #endregion "Elementos Selenium"

        #region "Atributos Selenium Convertidos"

        public ISeleniumWebElementHelper Nome { get { return ConverterElemento(_nome); } private set { } }
        public ISeleniumWebElementHelper Email { get { return ConverterElemento(_email); } private set { } }
        public ISeleniumWebElementHelper Password { get { return ConverterElemento(_password); } private set { } }
        public ISeleniumWebElementHelper BtnSubmit { get { return ConverterElemento(_btnSubmit); } private set { } }
        public ISeleniumWebElementHelper ConfirmPassword { get { return ConverterElemento(_confirmPassword); } private set { } }

        #endregion "Atributos Selenium Convertidos"

        public override string ObterPaginaUrl()
        {
            return ConfigurationHelper.SiteUrl + paginaUrl;
        }

        public void Salvar(string nome, string email, string senha, string confirmacaoSenha)
        {
            Nome.PreencherCampo(nome);
            Email.PreencherCampo(email);
            Password.PreencherCampo(senha);
            ConfirmPassword.PreencherCampo(confirmacaoSenha);
            BtnSubmit.Clicar().Aguardar(tempoEspera);
        }
    }
}