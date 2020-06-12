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
    public class PhieuThuTienDAL : SQLDataProvider
    {
        public void PhieuThuTien_Insert(PhieuThuTien Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data.MaNV));
                cmd.Parameters.Add(new SqlParameter("@NgayThuTien", Data.NgayThuTien));
                cmd.Parameters.Add(new SqlParameter("@TienThu", Data.TienThu));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void PhieuThuTien_Delete(string Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuThuTien", Data));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public double PhieuThuTien_GetTongTien(string Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_GetTongTien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data));
                double kq = Convert.ToDouble(cmd.ExecuteScalar());
                connection.Close();
                return kq;
            }
        }
        public DataTable PhieuThuTien_GetPhieuThuTien(string Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_GetPhieuThuTien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
