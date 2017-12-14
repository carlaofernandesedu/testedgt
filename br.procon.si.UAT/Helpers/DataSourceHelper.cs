using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace br.procon.si.UAT.Helpers
{
    public class DataSourceHelper
    {
        public static string ObterConteudoJson(string caminhoArquivo)
        {
            string conteudoArquivo; ;
            using (var sr = new StreamReader(caminhoArquivo))
            {
                conteudoArquivo = sr.ReadToEnd();
            }
            return conteudoArquivo;
        }

        public static T ConverterPara<T>(string jsonData) where T : new()
        {
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static IEnumerable<T> ObterDadosParaTeste<T>(string testeId) where T : new()
        {
            var dataConfig = ConfigurationHelper.DataSourceConfigTest.Find(item => item.testeId == testeId);
            switch (dataConfig.tipoFonte.ToLower())
            {
                case "sql":
                    return SQLHelper.Instance(ConfigurationHelper.ObterConexaoBancoDeDados(dataConfig.nomeConexao)).Get<T>(dataConfig.fonte);
                default:
                    var pathExcel = Path.Combine(ConfigurationHelper.CaminhoPastaApp, dataConfig.fonte);
                    if (File.Exists(pathExcel))
                        return ExcelHelper.Instance(pathExcel).Get<T>(dataConfig.nomeConexao, dataConfig.testeId);
                    else
                        return null;
            }
            
        }

        
    }
}