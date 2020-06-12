using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class KeyPress_Even 
    {
        public static void So(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsDigit(e.KeyChar) || e.KeyChar == 8));
        }
        public static void Email(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || char.IsDigit(e.KeyChar) ||
                e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar== 64);
        }
        public static void BienSo(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || char.IsDigit(e.KeyChar) ||
                e.KeyChar == 8 || e.KeyChar == 45);
        }
    }
}
