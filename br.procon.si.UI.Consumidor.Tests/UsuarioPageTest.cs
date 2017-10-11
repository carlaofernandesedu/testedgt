using br.procon.si.UI.Consumidor.Tests.DTO;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using br.procon.si.UI.Consumidor.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    [TestClass]
    public class UsuarioPageTest : BaseUITest
    {
        #region Constantes

        private const string tituloPagina = "Autenticação - Sistema Integrado Procon";

        #endregion Constantes

        #region Membros

        private UsuarioDTO dto;
        private UsuarioPage page;

        #endregion Membros

        #region "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        private void ObterPagina()
        {
            page = Browser.ObterPagina<UsuarioPage>();
        }

        public override void Preparar(string testkey)
        {
            dto = DTOHelper.ConverterPara<UsuarioDTO>(TestContext.DataRow);
        }

        private void Salvar()
        {
            ObterPagina();
            page.Salvar(dto.Nome, dto.Email, dto.Password, dto.ConfirmPassword);
        }

        #endregion "Metodos de Suporte Reutilizacao procedimentos de (Arrange) e (Act)"

        #region "Metodos Validacao Teste"

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\datausuariopagefp001.csv", "datausuariopagefp001#csv", DataAccessMethod.Sequential), TestCategory("FP001"), TestMethod]
        public void UsuarioPage_FP_Execucao_CarregarPaginaUsuario()
        {
            Executar(Preparar, Salvar);
            Assert.IsNotNull(page);
        }

        #endregion "Metodos Validacao Teste"
    }
}