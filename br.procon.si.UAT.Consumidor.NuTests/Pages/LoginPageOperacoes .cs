using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using System;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
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

        public AcoesLogar Logar(string usuario, string senha)
        {
            AcoesLogar resultado = AcoesLogar.Incorreto;
            Email.PreencherCampo(usuario);
            Password.PreencherCampo(senha);
            //CapturarTela();
            BtnSubmit.ClicarEAguardar(tempoEspera);
            if (Driver.ObterUrl().ToLower() == new AtendimentoConsumidorPage().ObterPaginaUrl().ToLower())
                resultado = AcoesLogar.Sucesso;

            return resultado;
        }


    }
}