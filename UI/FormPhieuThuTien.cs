using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DATA;
using BUS;

namespace UI
{
    public partial class FormPhieuThuTien : Form
    {
        public FormPhieuThuTien()
        {
            InitializeComponent();
        }

        private void FormPhieuThuTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.XE' table. You can move, or remove it, as needed.
            this.xETableAdapter.Fill(this.qUAN_LY_GARADataSet.XE);
            txtMaNhanVien.Text=DATA.Info.NhanVien.MaNV;
            txtTenNhanVien.Text = TaiKhoanBUS.GetTenNhanVien();
            ResetTextBox();
            txtSoTienThu.KeyPress += KeyPress_Even.So;
        }

        private void cbBienSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void HienThiTongTien()
        {
            try
            {
                txtTongTien.Text = PhieuThuTienBUS.PhieuThuTien_GetTongTien(cbBienSo.Text).ToString();
            }
            catch (Exception ex)
            {
                txtTongTien.Text = "";
                MessageBox.Show("Xe chưa được sửa chữa!");
            }
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienThu.Text == "")
            {
                btnThemMoi.Enabled = false;
                txtConLai.Text = "";
                return;
            }
            btnThemMoi.Enabled = true;
            txtConLai.Text = (double.Parse(txtTongTien.Text) - double.Parse(txtSoTienThu.Text)).ToString();
        }
        private void ThemPhieuThuTien()
        {
            try
            {
                var ptt = new DATA.Info.PhieuThuTien();
                ptt.BienSo = cbBienSo.Text;
                ptt.MaNV = txtMaNhanVien.Text;
                ptt.NgayThuTien = dateNgayThuTien.Value.Date.ToString();
                ptt.TienThu = double.Parse(txtSoTienThu.Text);
                PhieuThuTienBUS.PhieuThuTien_Insert(ptt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoTienThu.Text) > int.Parse(txtTongTien.Text))
            {
                MessageBox.Show("Vượt quá số tiền tối đa!", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThemPhieuThuTien();
            ResetButtom();
            ResetTextBox();
        }
        private void ResetButtom()
        {
            btnXoa.Enabled = false;
            btnThemMoi.Enabled = false;
        }
        private void ResetTextBox()
        {
            txtSoTienThu.Text = "";
            txtConLai.Text = "";
            HienThiTongTien();
            tablePhieuSuaChua.DataSource = PhieuThuTienBUS.PhieuThuTien_GetPhieuThuTien(cbBienSo.Text);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            var frm = new BaoCaoPhieuThuTien(cbBienSo.Text);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuThuTienBUS.PhieuThuTien_Delete(tablePhieuSuaChua.CurrentRow.Cells[0].Value.ToString());
            ResetButtom();
            ResetTextBox();
        }

        private void tablePhieuSuaChua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

    }
}
