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
    public class XeDAL : SQLDataProvider
    {
        public DataTable Xe_GetBienSo()
        {
            using (var cmd = new SqlCommand("sp_Xe_GetBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public string Xe_GetSoLuong()
        {
            using (var cmd = new SqlCommand("sp_Xe_GetSoLuong", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                string dt = Convert.ToString(cmd.ExecuteScalar());
                return dt;
            }
        }
        public void Xe_Insert(Xe Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.HieuXe));
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data.TenChuXe));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", Data.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", Data.NgayTiepNhan));
                cmd.Parameters.Add(new SqlParameter("@MaNV", NhanVien.MaNV));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Xe_Update(Xe Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.HieuXe));
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data.TenChuXe));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", Data.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", Data.NgayTiepNhan));
                cmd.Parameters.Add(new SqlParameter("@TienNo", Data.TienNo));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Xe_Delete(string Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable Xe_GetAll()
        {
            using (var cmd = new SqlCommand("sp_Xe_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetTenChuXe()
        {
            using (var cmd = new SqlCommand("sp_Xe_GetTenChuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetHieuXe()
        {
            using (var cmd = new SqlCommand("sp_Xe_GetHieuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetLikeHieuXe(string Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetLikeHieuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetLikeBienSo(string Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetLikeBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetLikeTenChuXe(string Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetlikeTenChuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
