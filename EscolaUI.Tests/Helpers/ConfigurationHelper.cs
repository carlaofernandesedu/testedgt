using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using System.IO;

namespace EscolaUI.Tests.Helpers
{
    public static class ConfigurationHelper
    {
        public static int SegundosAguardandoCargaWebDriverWait
        {
            get { return 30; }
        }

        public static int SegundosExecucaoScript
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["SegundosExecucaoScript"]); }
        }
        public static int SegundosExecucaoPagina
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["SegundosExecucaoPagina"]); }
        }

        public static string FirefoxDriver
        {
            get
            {
                // return string.Format("{0}", ConfigurationManager.AppSettings["FirefoxDriver"]);
                //var pathFirefox = Path.Combine(FolderPath, "Drivers");
                var pathFirefox = ConfigurationManager.AppSettings["FirefoxDriver"]; ;
                return pathFirefox;
            }
        }

        public static string SiteUrl
        {
            get { return ConfigurationManager.AppSettings["SiteUrl"]; }
        }

        public static string LoginUrl
        {
            get { return ConfigurationManager.AppSettings["LoginUrl"]; }
        }

        public static string ChromeDrive
        {
            get
            {
                // return string.Format("{0}", ConfigurationManager.AppSettings["ChromeDrive"]);
                //var pathChrome = Path.Combine(FolderPath, "Drivers");
                //var pathChrome = Path.Combine(FolderPath);
                var pathChrome = ConfigurationManager.AppSettings["ChromeDrive"];
                return pathChrome;
            }
        }

        public static string FolderPath
        {
            get { return Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())); }
        }

        public static string FolderPicture
        {
            get
            {
                // return string.Format("{0}{1}", FolderPath, ConfigurationManager.AppSettings["FolderPicture"]);
                return Path.Combine(FolderPath, ConfigurationManager.AppSettings["FolderPicture"]);
            }
        }

        public static string BrowserType
        {
            get { return ConfigurationManager.AppSettings["BrowserType"]; }
        }
    }

    
}
