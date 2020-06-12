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
    public class TaiKhoanBUS
    {
        private static readonly TaiKhoanDAL db = new TaiKhoanDAL();
        public static bool TaiKhoan_CHECK(TaiKhoan Data)
        {
            return db.TaiKhoan_CHECK(Data);
        }
        public static int TaiKhoan_GetID(TaiKhoan Data)
        {
            return db.TaiKhoan_GetID(Data);
        }
        public static string TaiKhoan_GetNV(TaiKhoan Data)
        {
            return db.TaiKhoan_GetNV(Data);
        }
        public static string GetEmail()
        {
            return db.GetEmail(NhanVien.MaNV);
        }
        public static string GetSDT()
        {
            return db.GetSDT(NhanVien.MaNV);
        }
        public static string GetDiaChi()
        {
            return db.GetDiaChi(NhanVien.MaNV);
        }
        public static string GetPhongBan()
        {
            return db.GetPhongBan(NhanVien.MaNV);
        }
        public static string GetTenNhanVien()
        {
            return db.GetTenNhanVien(NhanVien.MaNV);
        }
        public static string GetMoTa()
        {
            return db.GetMoTa(NhanVien.PermissionID);
        }
    }
}
