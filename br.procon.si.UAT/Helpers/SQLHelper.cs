using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace br.procon.si.UAT.Helpers
{
    public class SQLHelper
    {
        private string _connectionString;
        private int _commandTimeout;

        public static SQLHelper Instance(string connectionstring, int commandTimeout = 300)
        {
            return new SQLHelper(connectionstring, commandTimeout);
        }

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
            return Get<T>(query, null);
        }
    }
}