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
    public class PhieuThuTienBUS
    {
        private static readonly PhieuThuTienDAL db = new PhieuThuTienDAL();
        public static void PhieuThuTien_Insert(PhieuThuTien Data)
        {
            db.PhieuThuTien_Insert(Data);
        }
        public static void PhieuThuTien_Delete(string Data)
        {
            db.PhieuThuTien_Delete(Data);
        }
        public static double PhieuThuTien_GetTongTien(string Data)
        {
            return db.PhieuThuTien_GetTongTien(Data);
        }
        public static DataTable PhieuThuTien_GetPhieuThuTien(string Data)
        {
            return db.PhieuThuTien_GetPhieuThuTien(Data);
        }
    }
}
