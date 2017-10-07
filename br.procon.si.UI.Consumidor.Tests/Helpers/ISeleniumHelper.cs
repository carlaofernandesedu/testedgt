using br.procon.si.UI.Consumidor.Tests.Pages;
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
        void PreencherValorNoElemento(string idCampo, string valorCampo);
        void ClicarLinkSite(string linkText);
        void ClicarBotaoSite(string botaoId);
        void LimparCookies(bool isOk = true);
        void Maximizar(bool isOk = true);
        void Fechar();
        void EsperarProcessamento(int segundos);
        void InicializarElementos(object pagina);
        string ObterUrl();
        string NavegarPara(string url);
        string ObterTextoDoElementoPorClasse(string className);
        string ObterTextoDoElementoPorId(string id);
        string ObterTextoDoElementoPorXPath(string xPath);
        string ObterTitulo();
        bool ValidarConteudoUrl(string conteudo);
        IWebElement ObterElementoPorId(string id);
        IWebElement ObterElementoPorNome(string nome);
        IEnumerable<IWebElement> ObterElementosPorClasse(string className);
        T ObterPagina<T>(bool limparCookies = true, bool maximizado = true) where T : BasePage, new();
    }
}
