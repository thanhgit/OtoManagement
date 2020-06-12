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
    public partial class BaoCaoSuaChua : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoSuaChua(string Data)
        {
            InitializeComponent();
            MaPhieuSuaChua = Data;
        }
        private string MaPhieuSuaChua;
        private void BaoCaoSuaChua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUAN_LY_GARADataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.QUAN_LY_GARADataSet.DataTable1,MaPhieuSuaChua);

            this.reportViewer1.RefreshReport();
        }
    }
}