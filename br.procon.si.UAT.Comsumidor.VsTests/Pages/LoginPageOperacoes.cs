using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static br.procon.si.UAT.Helpers.SeleniumWebElementHelper;

namespace br.procon.si.UAT.Consumidor.VsTests.Pages
{
    public partial class LoginPage : BasePage
    {
        public LoginPage()
        {
        }

        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + paginaUrl).AbsoluteUri;
        }

        public void Logar(string usuario, string senha)
        {
            Email.PreencherCampo(usuario);
            Password.PreencherCampo(senha);
            //CapturarTela();
            BtnSubmit.ClicarEAguardar(tempoEspera);
        }
    }
}