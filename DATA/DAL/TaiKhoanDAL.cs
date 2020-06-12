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
    public class TaiKhoanDAL : SQLDataProvider
    {
        public bool TaiKhoan_CHECK(TaiKhoan Data)
        {
            using (var cmd = new SqlCommand("sp_TaiKhoan_CHECK", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TaiKhoan", Data.TenTruyCap));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", Data.MatKhau));
                bool kq = (bool)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public string TaiKhoan_GetNV(TaiKhoan Data)
        {
            using (var cmd = new SqlCommand("sp_TaiKhoan_GetNV", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TaiKhoan", Data.TenTruyCap));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public int TaiKhoan_GetID(TaiKhoan Data)
        {
            using (var cmd = new SqlCommand("sp_TaiKhoan_GetID", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TaiKhoan", Data.TenTruyCap));
                int kq = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return kq;
            }
        }
        public string GetTenNhanVien(string Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_GetTenNhanVien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public string GetEmail(string Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_GetEmail", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public string GetSDT(string Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_GetSDT", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public string GetDiaChi(string Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_GetDiaChi", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public string GetPhongBan(string Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_GetPhongBan", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public string GetMoTa(int Data)
        {
            using (var cmd = new SqlCommand("sp_TaiKhoan_GetMoTa", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PermissionID", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
    }
}
