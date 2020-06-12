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
    public partial class FormQLHieuXe : Form
    {
        public FormQLHieuXe()
        {
            InitializeComponent();
            dgvDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetAll();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemHieuXe();
            ResetTextBox();
            ResetButton();
        }
        private void ThemHieuXe()
        {
            var hx = new DATA.Info.HieuXe();
            try
            {
                hx.TenHieuXe = txtHieuXe.Text;
                hx.NuocSanXuat = txtNuocSanXuat.Text;
                HieuXeBUS.HieuXe_Insert(hx);
                dgvDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatHieuXe()
        {
            var hx = new DATA.Info.HieuXe();
            try
            {
                hx.TenHieuXe = txtHieuXe.Text;
                hx.NuocSanXuat = txtNuocSanXuat.Text;
                HieuXeBUS.HieuXe_Update(hx);
                dgvDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void XoaHieuXe()
        {
            var hx = new DATA.Info.HieuXe();
            try
            {
                hx.TenHieuXe = dgvDanhSachHieuXe.CurrentRow.Cells[0].Value.ToString();
                hx.NuocSanXuat = dgvDanhSachHieuXe.CurrentRow.Cells[1].Value.ToString();
                HieuXeBUS.HieuXe_Delete(hx);
                dgvDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetTextBox()
        {
            txtHieuXe.Text = "";
            txtNuocSanXuat.Text = "";
        }
        private bool KiemTraTextBox()
        {
            if (txtHieuXe.Text == "") return false;
            if (txtNuocSanXuat.Text == "") return false;
            return true;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraTextBox()) btnThemMoi.Enabled = true;
            else
                ResetButton();
        }

        private void tableDSTienCong_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void tableDSTienCong_DoubleClick(object sender, EventArgs e)
        {
            txtHieuXe.Text = dgvDanhSachHieuXe.CurrentRow.Cells[0].Value.ToString();
            txtNuocSanXuat.Text = dgvDanhSachHieuXe.CurrentRow.Cells[1].Value.ToString();
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
            CapNhatHieuXe();
            ResetButton();
            ResetTextBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaHieuXe();
            ResetButton();
            ResetTextBox();
        }
    }
}
