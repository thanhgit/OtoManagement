using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI
{
    public partial class BCDoanhSo : DevExpress.XtraEditors.XtraForm
    {
        private DateTime date;
        public BCDoanhSo(DateTime Data)
        {
            InitializeComponent();
            date = Data;
        }

        private void BCDoanhSo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUAN_LY_GARADataSet.sp_BaoCaoDoanhThu' table. You can move, or remove it, as needed.
            this.sp_BaoCaoDoanhThuTableAdapter.Fill(this.QUAN_LY_GARADataSet.sp_BaoCaoDoanhThu,date);

            this.reportViewer1.RefreshReport();
        }
    }
}