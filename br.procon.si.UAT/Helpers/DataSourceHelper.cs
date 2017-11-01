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
            return SQLHelper.Instance(ConfigurationHelper.ObterConexaoBancoDeDados(dataConfig.nomeConexao)).Get<T>(dataConfig.fonte);
        }
    }
}