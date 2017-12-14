using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace br.procon.si.UAT.Helpers
{
    public class ExcelHelper
    {
        private string _connectionString;
        private int _commandTimeout;

        public static ExcelHelper Instance(string connectionstring, int commandTimeout = 300)
        {
            return new ExcelHelper(connectionstring, commandTimeout);
        }

        public static ExcelHelper Instance(string caminhoArquivo)
        {
            var connectionstring = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", caminhoArquivo);
            return new ExcelHelper(connectionstring);
        }

        public ExcelHelper(string connectionString, int commandTimeout = 300)
        {
            _connectionString = connectionString;
            _commandTimeout = commandTimeout;
        }

        public void SetCommandTimeout(int commandTimeout)
        {
            _commandTimeout = commandTimeout;
        }

        public OleDbConnection Connection
        {
            get
            {
                return Connection;
            }
        }

        public IEnumerable<T> Get<T>(string nomeSheet, string testeId)
        {
            var comandoSQL = string.Format("select * from [{0}$] where testeid='{1}'", nomeSheet, testeId);
            using (IDbConnection conn = new OleDbConnection(this._connectionString))
            {
                return conn.Query<T>(comandoSQL);
            }
        }
    
    }
}