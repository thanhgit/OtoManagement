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
    public class LoaiTienCongBUS
    {
        private static readonly LoaiTienCongDAL db = new LoaiTienCongDAL();
        public static DataTable LoaiTienCong_GetNoiDung()
        {
            return db.LoaiTienCong_GetNoiDung();
        }
        public static double LoaiTienCong_GetDonGia(string Data)
        {
            return db.LoaiTienCong_GetDonGia(Data);
        }
        public static void LoaiTienCong_Insert(LoaiTienCong Data)
        {
            db.LoaiTienCong_Insert(Data);
        }
        public static void LoaiTienCong_Update(LoaiTienCong Data)
        {
            db.LoaiTienCong_Update(Data);
        }
        public static void LoaiTienCong_Delete(LoaiTienCong Data)
        {
            db.LoaiTienCong_Delete(Data);
        }
        public static DataTable LoaiTienCong_GetAll()
        {
            return db.LoaiTienCong_GetAll();
        }
    }
}
