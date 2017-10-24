using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace br.procon.si.UAT.Helpers
{
    public class SQLHelper
    {
        private string _connectionString;
        private int _commandTimeout;

        public SQLHelper(string connectionString, int commandTimeout = 300)
        {
            _connectionString = connectionString;
            _commandTimeout = commandTimeout;
        }

        public void SetCommandTimeout(int commandTimeout)
        {
            _commandTimeout = commandTimeout;
        }


        public SqlConnection Connection
        {
            get
            {
                return Connection;
            }
        }

        public IEnumerable<T> Get<T>(string query, object parameter) where T : new()
        {
            using (IDbConnection conn = new SqlConnection(this._connectionString))
            {
                return conn.Query<T>(sql: query, param: parameter, commandTimeout: _commandTimeout, commandType: CommandType.Text);
            }
        }

        public IEnumerable<T> Get<T>(string query) where T : new()
        {
            return Get<T>(query,null);
        }
    }
}
