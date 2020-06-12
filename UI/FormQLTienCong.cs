using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DATA;

namespace UI
{
    public partial class FormQLTienCong : Form
    {
        public FormQLTienCong()
        {
            InitializeComponent();            
        }
        private void FormQLTienCong_Load(object sender, EventArgs e)
        {
            tableDSTienCong.DataSource = LoaiTienCongBUS.LoaiTienCong_GetAll();
            txtTienCong.KeyPress += KeyPress_Even.So;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemLoaiTienCong();
            ResetTextBox();
            ResetButton();
        }
        private void ThemLoaiTienCong()
        {
            var tc = new DATA.Info.LoaiTienCong();
            try
            {
                tc.DonGia = double.Parse(txtTienCong.Text);
                tc.NoiDungSuaChua = txtNoiDung.Text;
                LoaiTienCongBUS.LoaiTienCong_Insert(tc);
                tableDSTienCong.DataSource = LoaiTienCongBUS.LoaiTienCong_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatLoaiTienCong()
        {
            var tc = new DATA.Info.LoaiTienCong();
            try
            {
                tc.DonGia = double.Parse(txtTienCong.Text);
                tc.NoiDungSuaChua = txtNoiDung.Text;
                LoaiTienCongBUS.LoaiTienCong_Update(tc);
                tableDSTienCong.DataSource = LoaiTienCongBUS.LoaiTienCong_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XoaLoaiTienCong()
        {
            var tc = new DATA.Info.LoaiTienCong();
            try
            {
                tc.DonGia = double.Parse(tableDSTienCong.CurrentRow.Cells[1].Value.ToString());
                tc.NoiDungSuaChua = tableDSTienCong.CurrentRow.Cells[0].Value.ToString();
                LoaiTienCongBUS.LoaiTienCong_Delete(tc);
                tableDSTienCong.DataSource = LoaiTienCongBUS.LoaiTienCong_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetTextBox()
        {
            txtNoiDung.Text = "";
            txtTienCong.Text = "";
        }
        private bool KiemTraTextBox()
        {
            if (txtNoiDung.Text == "") return false;
            if (txtTienCong.Text == "") return false;
            return true;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraTextBox()) btnThemMoi.Enabled = true;
            else ResetButton();
        }

        private void tableDSTienCong_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void tableDSTienCong_DoubleClick(object sender, EventArgs e)
        {
            txtNoiDung.Text = tableDSTienCong.CurrentRow.Cells[0].Value.ToString();
            txtTienCong.Text = tableDSTienCong.CurrentRow.Cells[1].Value.ToString();
            btnCapNhat.Enabled = true;
        }
        private void ResetButton()
        {
            btnCapNhat.Enabled = false;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatLoaiTienCong();
            ResetButton();
            ResetTextBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaLoaiTienCong();
            ResetButton();
            ResetTextBox();
        }

    }
}
