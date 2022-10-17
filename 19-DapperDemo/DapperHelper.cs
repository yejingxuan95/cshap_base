using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DapperDemo
{
    public class DapperHelper
    {
        public IDbConnection Connection = null;
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DapperHelper()
        {  }

        public IDbConnection GetCon()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(ConnectionString);
            }
            else if (Connection.State == ConnectionState.Closed)
            {
                Connection.ConnectionString = ConnectionString;
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.ConnectionString = ConnectionString;
            }
            return Connection;
        }
    }
}
