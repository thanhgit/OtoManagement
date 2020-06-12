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
    public partial class BaoCaoTon : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoTon(DateTime Data)
        {
            InitializeComponent();
            date = Data;
        }
        private DateTime date;
        private void BaoCaoTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUAN_LY_GARADataSet.sp_BaoCaoTon' table. You can move, or remove it, as needed.
            this.sp_BaoCaoTonTableAdapter.Fill(this.QUAN_LY_GARADataSet.sp_BaoCaoTon,date);

            this.reportViewer1.RefreshReport();
        }
    }
}