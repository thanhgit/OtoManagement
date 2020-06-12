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
    public class XeBUS
    {
        private static readonly XeDAL db = new XeDAL();
        public static DataTable Xe_GetBienSo()
        {
            return db.Xe_GetBienSo();
        }
        public static string Xe_GetSoLuong()
        {
            return db.Xe_GetSoLuong();
        }
        public static void Xe_Insert(Xe Data)
        {
            db.Xe_Insert(Data);
        }
        public static void Xe_Update(Xe Data)
        {
            db.Xe_Update(Data);
        }
        public static void Xe_Delete(string Data)
        {
            db.Xe_Delete(Data);
        }
        public static DataTable Xe_GetAll()
        {
            return db.Xe_GetAll();
        }
        public static DataTable Xe_GetTenChuXe()
        {
            return db.Xe_GetTenChuXe();
        }
        public static DataTable Xe_GetHieuXe()
        {
            return db.Xe_GetHieuXe();
        }
        public static DataTable Xe_GetLikeHieuXe(string Data)
        {
            return db.Xe_GetLikeHieuXe(Data);
        }
        public static DataTable Xe_GetLikeBienSo(string Data)
        {
            return db.Xe_GetLikeBienSo(Data);
        }
        public static DataTable Xe_GetLikeTenChuXe(string Data)
        {
            return db.Xe_GetLikeTenChuXe(Data);
        }
    }
}
