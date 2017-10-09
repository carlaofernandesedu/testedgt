using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class LoginPageTest : BaseUITest
    {
        #region Membros

        private LoginPage page;
        private string email;
        private string password;

        private enum colunasCsv
        {
            testkey,
            email,
            senha
        };

        #endregion Membros

        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        private void ObterPagina()
        {
            page = Browser.ObterPagina<LoginPage>();
        }

        private void PrepararDados(string testkey)
        {
            ObterPagina();
            email = TestContext.DataRow[(int)colunasCsv.email].ToString();
            password = TestContext.DataRow[(int)colunasCsv.senha].ToString();
        }

        private void Logar()
        {
            page.Logar(email, password);
        }

        #endregion "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        #region "Metodos Validacao Teste"

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataloginpagefp001.csv", "dataloginpagefp001#csv", DataAccessMethod.Sequential), TestCategory("FP001"), TestMethod]
        public void LoginPage_FP_InformarDadosCorretos_RedirecionadoPaginaConsulta()
        {
            Executar(PrepararDados, Logar);
            Assert.AreEqual(new AtendimentoConsumidorPage().ObterPaginaUrl().ToLower(), Browser.ObterUrl().ToLower());
        }

        [TestCategory("FP001"), TestMethod]
        public void LoginPage_FP_InformarUrlPagina_PaginaCarregada()
        {
            Executar(null, ObterPagina);
            Assert.AreEqual("Autenticação - Sistema Integrado Procon", page.Titulo);
        }

        #endregion "Metodos Validacao Teste"
    }
}