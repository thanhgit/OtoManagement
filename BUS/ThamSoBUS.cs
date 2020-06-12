using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.DAL;

namespace BUS
{
    public class ThamSoBUS
    {
        private static readonly ThamSoDAL db = new ThamSoDAL();
        public static int ThamSo_Get()
        {
            return db.ThamSo_Get();
        }
        public static void ThamSo_Set(int Data)
        {
            db.ThamSo_Set(Data);
        }
    }
}
