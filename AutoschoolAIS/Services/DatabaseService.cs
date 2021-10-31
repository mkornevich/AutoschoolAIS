using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services
{
    public class DatabaseService : QueryFactory
    {
        private string _connectionString;


        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
            Connection = new SqlConnection(_connectionString);
            Compiler = new SqlServerCompiler();
            Connection.Open();
        }

        public SqlCommand CreateCommand(string sql)
        {
            return new SqlCommand(sql, (SqlConnection)Connection);
        }

        public SqlDataAdapter CreateDataAdapter(string sql)
        {
            return new SqlDataAdapter(CreateCommand(sql));
        }
    }
}
