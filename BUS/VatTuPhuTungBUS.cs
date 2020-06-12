using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA.DAL;
using DATA.Info;

namespace BUS
{
    public class VatTuPhuTungBUS
    {
        private static readonly VatTuPhuTungDAL db = new VatTuPhuTungDAL();
        public static DataTable VatTuPhuTung_GetMaVatTu()
        {
            return db.VatTuPhuTung_GetMaVatTu();
        }
        public static string VatTuPhuTung_ReturnTenVatTu(string Data)
        {
            return db.VatTuPhuTung_ReturnTenVatTu(Data);
        }
        public static double VatTuPhuTung_ReturnDonGia(string Data)
        {
            return db.VatTuPhuTung_ReturnDonGia(Data);
        }
        public static int VatTuPhuTung_ReturnTonKho(string Data)
        {
            return db.VatTuPhuTung_ReturnTonKho(Data);
        }
    }
}
