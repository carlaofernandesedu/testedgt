using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using System;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
{
    public class AtendimentoConsumidorPage : BasePage
    {
        #region Constantes

        private const string paginaUrl = "/atendimentoConsumidor";
        private const string xpathBotaoDetalhe = "//tbody[@id='historicoPesquisa']/tr[{0}]/td[6]/button/i";
        private const string xpathRegistroFicha = "//tbody[@id='historicoPesquisa']/tr[{0}]/td[2]";
        #endregion Constantes

        #region 
        #endregion

        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + paginaUrl).AbsoluteUri;
        }

        private RegistroFicha ObterRegistroFicha(int indice)
        {
            return new RegistroFicha(null,0); 
        }

        public class RegistroFicha
        {
            private ISeleniumWebElementHelper _ficha;
            private int _indice;

            internal RegistroFicha(ISeleniumWebElementHelper ficha, int indice)
            {
                _ficha = ficha;
                _indice = indice;
            }
            
            public void Detalhar()
            {
                _ficha.ObterElementoPorXPath(xpathBotaoDetalhe).Clicar();
            }
        }
    }
}