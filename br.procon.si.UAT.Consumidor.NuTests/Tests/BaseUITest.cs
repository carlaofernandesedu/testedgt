using br.procon.si.UAT.Helpers;
using NUnit.Framework;
using System;

namespace br.procon.si.UAT.Consumidor.NuTests.Tests
{
    public abstract class BaseUITest
    {
        protected SeleniumHelper Browser;

        [SetUp]
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

        [TearDown]
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