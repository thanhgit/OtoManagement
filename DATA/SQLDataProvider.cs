using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

namespace DATA
{
    public class SQLDataProvider
    {
        public static string connectionstring;
        public static SqlConnection connection = null;
        public SQLDataProvider()
        {
            if (connection == null)
            {
                connectionstring = ConfigurationManager.ConnectionStrings["UI.Properties.Settings.QUAN_LY_GARAConnectionString"].ToString();
                connection = new SqlConnection(connectionstring);
            }
        }
        public SqlConnection GetConnection()
        {
           if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    return connection;
                }
                else
                    return connection;
        }
    }
}

