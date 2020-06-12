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
    public class PhieuNhapVatTuPhuTungBUS
    {
        private static readonly PhieuNhapVatTuPhuTungDAL db = new PhieuNhapVatTuPhuTungDAL();
        public static void PhieuNhapVatTuPhuTung_Insert(PhieuNhapVatTuPhuTung Data)
        {
            db.PhieuNhapVatTuPhuTung_Insert(Data);
        }
        public static void PhieuNhapVatTuPhuTung_Update(PhieuNhapVatTuPhuTung Data)
        {
            db.PhieuNhapVatTuPhuTung_Update(Data);
        }
        public static DataTable PhieuNhapVatTuPhuTung_GetNewID()
        {
            return db.PhieuNhapVatTuPhuTung_GetNewID();
        }
        public static DataTable PhieuNhapVatTuPhuTung_GetPhieuNhapVatTuPhuTung(string Data)
        {
            return db.PhieuNhapVatTuPhuTung_GetPhieuNhapVatTuPhuTung(Data);
        }
        public static void PhieuNhapVatTuPhuTung_Delete(PhieuNhapVatTuPhuTung Data)
        {
            db.PhieuNhapVatTuPhuTung_Delete(Data);
        }
    }
}
