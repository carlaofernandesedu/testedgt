using br.procon.si.UI.Consumidor.Tests.DTO;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class LoginPageTest : BaseUITest
    {
        #region Constantes

        private const string tituloPagina = "Autenticação - Sistema Integrado Procon";

        #endregion Constantes

        #region Membros

        private LoginPage page;
        private LoginDTO dto;

        #endregion Membros

        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        public override void Preparar(string testkey)
        {
            dto = DTOHelper.ConverterPara<LoginDTO>(TestContext.DataRow);
        }

        private void ObterPagina()
        {
            page = Browser.ObterPagina<LoginPage>();
        }

        private void Logar()
        {
            Browser.ObterPagina<LoginPage>().Logar(dto.Email, dto.Senha);
        }

        #endregion "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        #region "Metodos Validacao Teste"

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataloginpagefp001.csv", "dataloginpagefp001#csv", DataAccessMethod.Sequential), TestCategory("FP001"), TestMethod]
        public void LoginPage_FP_InformarDadosCorretos_RedirecionadoPaginaConsulta()
        {
            Executar(Preparar, Logar);
            Assert.AreEqual(new AtendimentoConsumidorPage().ObterPaginaUrl().ToLower(), Browser.ObterUrl().ToLower());
        }

        [TestCategory("FP001"), TestMethod]
        public void LoginPage_FP_InformarUrlPagina_PaginaCarregada()
        {
            Executar(null, ObterPagina);
            Assert.AreEqual(tituloPagina, page.Titulo);
        }

        #endregion "Metodos Validacao Teste"
    }
}