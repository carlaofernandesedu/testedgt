using br.procon.si.UAT.Base;
using br.procon.si.UAT.Helpers;
using System;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
{
    public class AtendimentoConsumidorPage : BasePage
    {
        #region Constantes

        private const string paginaUrl = "/atendimentoConsumidor";

        #endregion Constantes

        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + paginaUrl).AbsoluteUri;
        }
    }
}