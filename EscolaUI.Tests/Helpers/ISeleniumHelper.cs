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
        string ObterUrl();
        bool ValidarConteudoUrl(string conteudo);
        string NavegarParaSite(string url);
        void ClicarLinkSite(string linkText);
        void ClicarBotaoSite(string botaoId);
        void PreencherTextBox(string idCampo, string valorCampo);
        string ObterTextoPorClasse(string className);
        string ObterTextoPorId(string id);
        string ObterTextoPorXPath(string xPath);
        IWebElement ObterElementoPorId(string id);
        IWebElement ObterElementoPorNome(string nome);
        IEnumerable<IWebElement> ObterElementosPorClasse(string className);
        void ObterScreenShot(string nome);
        void LimparCookies(bool isOk = true);
        void Maximizar(bool isOk = true);
        void Fechar();
        void ExecutarScripts(string javascript);
        string ObterTitulo();
    }
}
