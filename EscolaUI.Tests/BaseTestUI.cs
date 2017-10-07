using EscolaUI.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EscolaUI.Tests
{
    public class BaseUITest
    {
        public static SeleniumHelper Driver { get; private set; }

       [TestInitialize]
        public void SetupTest()
        {
            if (BaseUITest.Driver == null)
            {
                //ConfigurationHelper.BrowserType = (int)BrowserType.Firefox;
                //ConfigurationHelper.SegundosExecucaoPagina = 30;
                //ConfigurationHelper.SegundosExecucaoScript = 30;
                //ConfigurationHelper.FirefoxDriver = @"F:\Andre\2017\02SEMESTRE\devopsms";
                Driver = SeleniumHelper.Instance();
            }

            //Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            //Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));
            //Driver.Manage().Window.Maximize();
            Driver.AguardarCarregarPagina(ConfigurationHelper.TempodeEsperaExecucaoPagina);
            Driver.AguardarExecucaoScripts(ConfigurationHelper.TempodeEsperaExecucaoScript);
            //Driver.Maximizar();
        }

        [TestCleanup]
        public void TestCleanupTest()
        {
            try
            {
                Driver.Fechar();
                Driver = null;
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
