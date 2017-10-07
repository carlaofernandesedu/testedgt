using br.procon.si.UI.Consumidor.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    public class BaseUITest
    {
        protected SeleniumHelper Browser;

        [TestInitialize]
        public void SetupTest()
        {
            Browser = SeleniumHelper.Instance();
            Browser.AguardarCarregarPagina(ConfigurationHelper.TempoDeEsperaExecucaoPagina);
            Browser.AguardarExecucaoScripts(ConfigurationHelper.TempoDeEsperaExecucaoScript);
        }

        [TestCleanup]
        public void TestCleanupTest()
        {
            try
            {
                Browser.Fechar();
                Browser = null;
            }
            finally
            {
            }
        }
    }
}