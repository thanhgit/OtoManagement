using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormBCDoanhSo : Form
    {
        public FormBCDoanhSo()
        {
            InitializeComponent();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (ThangChon.DateTime.Year == 1)
            {
                MessageBox.Show("Hãy chọn tháng để lập báo cáo!", "Chú ý!!!");
                return;
            }
            var frm = new BCDoanhSo(ThangChon.DateTime);
            frm.Show();
        }
    }
}
