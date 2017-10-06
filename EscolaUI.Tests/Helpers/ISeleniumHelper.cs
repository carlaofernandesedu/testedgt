using EscolaUI.Tests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaUI.Tests.Helpers
{
    public interface ISeleniumHelper
    {
        void AguardarExecucaoScripts(int segundos);
        void AguardarCarregarPagina(int segundos);
        void ObterScreenShot(string nome);
        void ClicarLinkSite(string linkText);
        void ClicarBotaoSite(string botaoId);
        void LimparCookies(bool isOk = true);
        void Maximizar(bool isOk = true);
        void Fechar();
        void ExecutarScripts(string javascript);
        void PreencherTextBox(string idCampo, string valorCampo);
        void InicializarElementos(object Page);
        string ObterUrl();
        string NavegarPara(string url);
        string ObterTextoPorClasse(string className);
        string ObterTextoPorId(string id);
        string ObterTextoPorXPath(string xPath);
        string ObterTitulo();
        bool ValidarConteudoUrl(string conteudo);
        IWebElement ObterElementoPorId(string id);
        IWebElement ObterElementoPorNome(string nome);
        IEnumerable<IWebElement> ObterElementosPorClasse(string className);
        T ObterPagina<T>(bool limparCookies = true, bool maximizado = true) where T : BasePage, new();
    }
}
