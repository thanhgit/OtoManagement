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
    public class VatTuPhuTungDAL : SQLDataProvider
    {
        public DataTable VatTuPhuTung_GetMaVatTu()
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetMaVatTu", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public string VatTuPhuTung_ReturnTenVatTu(string Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_ReturnTenVatTu", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data));
                string kq = (string)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
        public double VatTuPhuTung_ReturnDonGia(string Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_ReturnDonGia", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data));
                double kq = Convert.ToDouble(cmd.ExecuteScalar());
                connection.Close();
                return kq;
            }
        }
        public int VatTuPhuTung_ReturnTonKho(string Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_ReturnTonKho", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data));
                int kq = (int)cmd.ExecuteScalar();
                connection.Close();
                return kq;
            }
        }
    }
}
