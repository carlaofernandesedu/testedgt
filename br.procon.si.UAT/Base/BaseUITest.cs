using br.procon.si.UAT.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace br.procon.si.UAT.Base
{
    public abstract class BaseUITest
    {
        protected SeleniumHelper Browser;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public virtual void Inicializar()
        {
            Browser = SeleniumHelper.Instance();
            Browser.AguardarCarregarPagina(ConfigurationHelper.TempoDeEsperaExecucaoPagina);
            Browser.AguardarExecucaoScripts(ConfigurationHelper.TempoDeEsperaExecucaoScript);
        }

        public abstract void Preparar(string testkey);

        public virtual T Executar<T>(Action<string> arrange, Func<T> act, string testkey = "")
            where T : class
        {
            arrange?.Invoke(testkey);
            return act?.Invoke();
        }

        public virtual void Executar(Action<string> arrange, Action act, string testkey = "")
        {
            arrange?.Invoke(testkey);
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