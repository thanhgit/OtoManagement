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
    public class LoaiTienCongDAL : SQLDataProvider
    {
        public DataTable LoaiTienCong_GetNoiDung()
        {
            using (var cmd = new SqlCommand("sp_LoaiTienCong_GetNoiDung", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public double LoaiTienCong_GetDonGia(string Data)
        {
            using (var cmd = new SqlCommand("sp_LoaiTienCong_GetDonGia", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NoiDung", Data));
                double kq = Convert.ToDouble(cmd.ExecuteScalar());
                connection.Close();
                return kq;
            }
        }
        public void LoaiTienCong_Insert(LoaiTienCong Data)
        {
            using (var cmd = new SqlCommand("sp_LoaiTienCong_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void LoaiTienCong_Update(LoaiTienCong Data)
        {
            using (var cmd = new SqlCommand("sp_LoaiTienCong_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void LoaiTienCong_Delete(LoaiTienCong Data)
        {
            using (var cmd = new SqlCommand("sp_LoaiTienCong_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable LoaiTienCong_GetAll()
        {
            using (var cmd = new SqlCommand("sp_LoaiTienCong_GetAll", GetConnection()))
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
