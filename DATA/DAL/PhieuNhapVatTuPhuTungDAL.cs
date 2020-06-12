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
    public class PhieuNhapVatTuPhuTungDAL : SQLDataProvider
    {
        public void PhieuNhapVatTuPhuTung_Insert(PhieuNhapVatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", Data.MaPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@TenVatTu", Data.TenVatTu));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void PhieuNhapVatTuPhuTung_Update(PhieuNhapVatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", Data.MaPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable PhieuNhapVatTuPhuTung_GetNewID()
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_GetNextID", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable PhieuNhapVatTuPhuTung_GetPhieuNhapVatTuPhuTung(string Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_GetPhieuNhapVatTuPhuTung", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", Data));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void PhieuNhapVatTuPhuTung_Delete(PhieuNhapVatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SoPhieuNhap", Data.MaPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
