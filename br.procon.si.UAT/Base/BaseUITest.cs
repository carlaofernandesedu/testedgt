using br.procon.si.UAT.Helpers;
using System;
using System.Collections.Generic;

namespace br.procon.si.UAT.Base
{
    public abstract class BaseUITest
    {
        protected SeleniumHelper Browser;

        public virtual void Inicializar()
        {
            Browser = SeleniumHelper.Instance();
            Browser.AguardarCarregarPagina(ConfigurationHelper.TempoDeEsperaExecucaoPagina);
            Browser.AguardarExecucaoScripts(ConfigurationHelper.TempoDeEsperaExecucaoScript);
        }

        public abstract void Preparar(string testeId);

        public virtual IEnumerable<T> ObterDadosDoDataSource<T>(string testeId) where T : new()
        {
            return DataSourceHelper.ObterDadosParaTeste<T>(testeId);
        }

        public virtual T Executar<T>(Action<string> arrange, Func<T> act, string testeId = "")
            where T : class
        {
            arrange?.Invoke(testeId);
            return act?.Invoke();
        }

        public virtual void Executar(Action<string> arrange, Action act, string testeId = "")
        {
            arrange?.Invoke(testeId);
            act?.Invoke();
        }

        public virtual void Finalizar()
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