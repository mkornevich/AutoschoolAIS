using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Utils
{
    public static class DbUtils
    {
        public static void DataRowToParams(DataRow row, SqlParameterCollection parameters)
        {
            foreach (DataColumn col in row.Table.Columns)
            {
                parameters.AddWithValue(col.ColumnName, row[col.ColumnName]);
            }
        }
    }
}
