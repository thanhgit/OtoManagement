using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DATA.Info;

namespace DATA.DAL
{
    public class HieuXeDAL : SQLDataProvider
    {
        public DataTable HieuXe_GetHieuXe()
        {
            using (var cmd = new SqlCommand("sp_HieuXe_GetHieuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void HieuXe_Insert(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.Parameters.Add(new SqlParameter("@NuocSanXuat", Data.NuocSanXuat));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void HieuXe_Update(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.Parameters.Add(new SqlParameter("@NuocSanXuat", Data.NuocSanXuat));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void HieuXe_Delete(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable HieuXe_GetAll()
        {
            using (var cmd = new SqlCommand("sp_HieuXe_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
