using br.procon.si.UI.Consumidor.Tests.Base;
using br.procon.si.UI.Consumidor.Tests.Helpers;
using System;

namespace br.procon.si.UI.Consumidor.Tests.Pages
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