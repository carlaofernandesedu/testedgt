using br.procon.si.UI.Consumidor.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        }

        public virtual T Executar<T>(Action arrange, Func<T> act)
            where T : class
        {
            arrange?.Invoke();
            return act?.Invoke();
        }

        public virtual void Executar(Action arrange, Action act)
        {
            arrange?.Invoke();
            act?.Invoke();
        }

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