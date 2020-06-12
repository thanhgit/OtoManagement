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
    public partial class BaoCaoPhieuThuTien : DevExpress.XtraEditors.XtraForm
    {
        private string BienSo;
        public BaoCaoPhieuThuTien(string Data)
        {
            InitializeComponent();
            BienSo = Data;
        }

        private void BaoCaoPhieuThuTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUAN_LY_GARADataSet.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.QUAN_LY_GARADataSet.DataTable2,BienSo);

            this.reportViewer1.RefreshReport();
        }
    }
}