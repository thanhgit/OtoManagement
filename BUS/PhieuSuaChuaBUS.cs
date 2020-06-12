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
    public class PhieuSuaChuaBUS
    {
        private static readonly PhieuSuaChuaDAL db = new PhieuSuaChuaDAL();
        public static void PhieuSuaChua_Insert(PhieuSuaChua Data)
        {
            db.PhieuSuaChua_Insert(Data);
        }
        public static void PhieuSuaChua_Delete(PhieuSuaChua Data)
        {
            db.PhieuSuaChua_Delete(Data);
        }
        public static DataTable PhieuSuaChua_GetMaPhieuSuaChua(string Data)
        {
            return db.PhieuSuaChua_GetMaPhieuSuaChua(Data);
        }
        public static DataTable PhieuSuaChua_GetPhieuSuaChua(string BienSo, string MaPhieuSuaChua)
        {
            return db.PhieuSuaChua_GetPhieuSuaChua(BienSo,MaPhieuSuaChua);
        }
        public static DataTable PhieuSuaChua_NewID(string Data)
        {
            return db.PhieuSuaChua_NewID(Data);
        }
    }
}
