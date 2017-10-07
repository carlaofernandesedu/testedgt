using br.procon.si.UI.Consumidor.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace br.procon.si.UI.Consumidor.Tests
{
    public abstract class BaseUITest
    {
        protected SeleniumHelper Browser;

        [TestInitialize]
        public virtual void Inicializar()
        {
            Browser = SeleniumHelper.Instance();
            Browser.AguardarCarregarPagina(ConfigurationHelper.TempoDeEsperaExecucaoPagina);
            Browser.AguardarExecucaoScripts(ConfigurationHelper.TempoDeEsperaExecucaoScript);
            Preparar();
            Executar();
        }

        protected virtual void Preparar()
        {
        }

        protected abstract void Executar();

        [TestCleanup]
        public virtual void TestCleanupTest()
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