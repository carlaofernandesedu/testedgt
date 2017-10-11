using br.procon.si.UI.Consumidor.Tests.Base;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace br.procon.si.UI.Consumidor.Tests.Helpers
{
    public interface ISeleniumHelper
    {
        void AguardarExecucaoScripts(int segundos);

        void ExecutarScripts(string javascript);

        void AguardarCarregarPagina(int segundos);

        void CapturarTela(string nomeArquivo);

        ISeleniumHelper PreencherValorNoElemento(string idCampo, string valorCampo);

        void ClicarLinkSite(string linkText);

        void ClicarBotaoSite(string botaoId);

        void LimparCookies(bool isOk = true);

        void Maximizar(bool isOk = true);

        void Fechar();

        ISeleniumHelper Aguardar(int segundos);

        void InicializarElementos(object pagina);

        string ObterUrl();

        string NavegarPara(string url);

        string ObterTextoDoElementoPorClasse(string className);

        string ObterTextoDoElementoPorId(string id);

        string ObterTextoDoElementoPorXPath(string xPath);

        string ObterTitulo();

        bool ValidarConteudoUrl(string conteudo);

        ISeleniumWebElementHelper ObterElementoPorId(string id);

        ISeleniumWebElementHelper ObterElementoPorNome(string nome);
        List<ISeleniumWebElementHelper> ObterElementosPorNome(string nome);

        ISeleniumWebElementHelper ObterElementoPorCssSelector(string cssSelector);

        IEnumerable<IWebElement> ObterElementosPorClasse(string className);

        void ObterFocoNaPagina();

        void ObterFocoNoElementoPorId(string id);

        T ObterPagina<T>(bool limparCookies = true, bool maximizado = true) where T : BasePage, new();
    }
}