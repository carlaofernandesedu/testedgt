using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace br.procon.si.UAT.Helpers
{
    public static class ConfigurationHelper
    {
        private const string datasourceJson = "datasource.json";

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
                var pathFirefox = ConfigurationManager.AppSettings[nameof(CaminhoPastaFirefoxDriver)]; ;
                return pathFirefox;
            }
        }

        public static string CaminhoPastaChromeDrive
        {
            get
            {
                // return string.Format("{0}", ConfigurationManager.AppSettings["ChromeDrive"]);
                var pathChrome = ConfigurationManager.AppSettings[nameof(CaminhoPastaChromeDrive)];
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
                return Path.Combine(ConfigurationManager.AppSettings[nameof(CaminhoPastaImagens)]);
            }
        }

        private static string JsonData
        {
            get
            {
                //string conteudoArquivo;
                //using (var sr = new StreamReader(Path.Combine(CaminhoPastaApp, datasourceJson)))
                //{
                //    conteudoArquivo = sr.ReadToEnd();
                //}
                //return conteudoArquivo;
                return DataSourceHelper.ObterConteudoJson(Path.Combine(CaminhoPastaApp, datasourceJson));
            }
        }

        private static List<ContextoDadosTeste> _dataSourceConfigTest;

        public static List<ContextoDadosTeste> DataSourceConfigTest
        {
            get
            {
                //return _dataSourceTest ?? (_dataSourceTest = JsonConvert.DeserializeObject<List<ContextoDadosTeste>>(JsonData));
                return _dataSourceConfigTest ?? (_dataSourceConfigTest = DataSourceHelper.ConverterPara<List<ContextoDadosTeste>>(JsonData));
            }
   
        }

        public static string ObterConexaoBancoDeDados(string nome)
        {
            var conexao = string.IsNullOrEmpty(nome) ? ConfigurationManager.ConnectionStrings[ConfigurationManager.ConnectionStrings.Count - 1].ConnectionString : ConfigurationManager.ConnectionStrings[nome].ConnectionString;
            return conexao;
        }
    }
}