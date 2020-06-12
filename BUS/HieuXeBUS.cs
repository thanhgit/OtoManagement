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
    public class HieuXeBUS
    {
        private static readonly HieuXeDAL db = new HieuXeDAL();
        public static DataTable HieuXe_GetHieuXe()
        {
            return db.HieuXe_GetHieuXe();
        }
        public static void HieuXe_Insert(HieuXe Data)
        {
            db.HieuXe_Insert(Data);
        }
        public static void HieuXe_Update(HieuXe Data)
        {
            db.HieuXe_Update(Data);
        }
        public static void HieuXe_Delete(HieuXe Data)
        {
            db.HieuXe_Delete(Data);
        }
        public static DataTable HieuXe_GetAll()
        {
            return db.HieuXe_GetAll();
        }
    }
}
