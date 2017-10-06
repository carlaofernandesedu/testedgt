using EscolaUI.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EscolaUI.Tests
{
    public class BaseUI2Test
    {
        protected SeleniumHelper Browser; 

       [TestInitialize]
        public void SetupTest()
        {
            Browser = SeleniumHelper.Instance();
            Browser.AguardarCarregarPagina(ConfigurationHelper.SegundosExecucaoPagina);
            Browser.AguardarExecucaoScripts(ConfigurationHelper.SegundosExecucaoScript);
        }

        [TestCleanup]
        public void TestCleanupTest()
        {
            try
            {
                Browser.Fechar();
                Browser = null;
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
