using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
{
    public partial class UsuarioPage : BasePage
    {
        public void Salvar(string nome, string email, string senha, string confirmacaoSenha)
        {
            Nome.PreencherCampo(nome);
            Email.PreencherCampo(email);
            Password.PreencherCampo(senha);
            ConfirmPassword.PreencherCampo(confirmacaoSenha);
            BtnSubmit.Clicar().Aguardar(tempoEspera);
        }

        public override string ObterPaginaUrl()
        {
            return ConfigurationHelper.SiteUrl + paginaUrl;
        }
    }
}