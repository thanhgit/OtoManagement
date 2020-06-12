using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DATA.DAL
{
    public class ThamSoDAL : SQLDataProvider
    {
        public int ThamSo_Get()
        {
            using (var cmd = new SqlCommand("sp_ThamSo_Get", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int kq = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return kq;
            }
        }
        public void ThamSo_Set(int Data)
        {
            using (var cmd = new SqlCommand("sp_ThamSo_Set", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ThamSo", Data));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
