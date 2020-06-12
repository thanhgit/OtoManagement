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
    public class PhieuSuaChuaDAL : SQLDataProvider
    {
        public void PhieuSuaChua_Insert(PhieuSuaChua Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", Data.MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@NoiDung", Data.NoiDung));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@MaNV", NhanVien.MaNV));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void PhieuSuaChua_Delete(PhieuSuaChua Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", Data.MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@NoiDung", Data.NoiDung));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable PhieuSuaChua_NewID(string Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_NewID", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable PhieuSuaChua_GetMaPhieuSuaChua(string Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetMaPhieuSuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable PhieuSuaChua_GetPhieuSuaChua(string BienSo, string MaPhieuSuaChua)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetPhieuSuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", MaPhieuSuaChua));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
