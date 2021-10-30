using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services
{
    public class DatabaseService
    {
        private string _connectionString;

        public SqlConnection Connection { get; private set; }

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
            Connection = new SqlConnection(_connectionString);
            Connection.Open();
        }

        public SqlCommand CreateCommand(string sql)
        {
            return new SqlCommand(sql, Connection);
        }

        public SqlDataAdapter CreateDataAdapter(string sql)
        {
            return new SqlDataAdapter(CreateCommand(sql));
        }
    }
}
