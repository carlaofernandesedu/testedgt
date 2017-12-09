using br.procon.si.UAT.Consumidor.VsTests.Pages;
using br.procon.si.UAT.Consumidor.VsTests.DTO;
using br.procon.si.UAT.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UAT.Consumidor.VsTests.Tests
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

        #endregion "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        #region "Metodos Validacao Teste"

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\loginpagefp001.csv", "loginpagefp001#csv", DataAccessMethod.Sequential), TestCategory("Login"), TestMethod]
        public void FP001_InformarDadosCorretos_RedirecionadoPaginaConsulta()
        {
            Executar(Preparar, () => { Browser.ObterPagina<LoginPage>().Logar(dto.Email, dto.Senha); });
            Assert.AreEqual(new AtendimentoConsumidorPage().ObterPaginaUrl().ToLower(), Browser.ObterUrl().ToLower());
        }

        [TestCategory("Login"), TestMethod]
        public void FP002_InformarUrlPagina_PaginaCarregada()
        {
            Executar(null, () => { page = Browser.ObterPagina<LoginPage>(); });
            Assert.AreEqual(tituloPagina, page.Titulo);
        }

        #endregion "Metodos Validacao Teste"
    }
}