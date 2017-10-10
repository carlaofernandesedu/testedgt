using System;
using System.Configuration;
using System.IO;

namespace br.procon.si.UI.Consumidor.Tests.Helpers
{
    public static class ConfigurationHelper
    {
        public static int TempoDeEsperaCargaWebDriverWait
        {
            get { return 15; }
        }

        public static int TempoDeEsperaExecucaoScript
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["SegundosExecucaoScript"]); }
        }

        public static int TempoDeEsperaExecucaoPagina
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["SegundosExecucaoPagina"]); }
        }

        public static string NomeDriver
        {
            get { return ConfigurationManager.AppSettings["BrowserType"]; }
        }

        public static string CaminhoPastaFirefoxDriver
        {
            get
            {
                var pathFirefox = ConfigurationManager.AppSettings["FirefoxDriver"]; ;
                return pathFirefox;
            }
        }

        public static string CaminhoPastaChromeDrive
        {
            get
            {
                // return string.Format("{0}", ConfigurationManager.AppSettings["ChromeDrive"]);
                var pathChrome = ConfigurationManager.AppSettings["ChromeDrive"];
                return pathChrome;
            }
        }

        public static string SiteUrl
        {
            get { return ConfigurationManager.AppSettings[nameof(SiteUrl)]; }
        }

        public static string CaminhoPastaApp
        {
            get { return Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())); }
        }

        public static string CaminhoPastaImagens
        {
            get
            {
                // return string.Format("{0}{1}", FolderPath, ConfigurationManager.AppSettings["FolderPicture"]);
                return Path.Combine(CaminhoPastaApp, ConfigurationManager.AppSettings["FolderPicture"]);
            }
        }
    }
}