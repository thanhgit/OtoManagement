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
    public partial class FormQLVatTu : Form
    {
        public FormQLVatTu()
        {
            InitializeComponent();
            dateNgayNhap.Format = DateTimePickerFormat.Custom;
            dateNgayNhap.CustomFormat = "yyyy/MM/dd";
        }

        private void FormQLVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.PHIEUNHAPVATTUPHUTUNG' table. You can move, or remove it, as needed.
            this.pHIEUNHAPVATTUPHUTUNGTableAdapter.Fill(this.qUAN_LY_GARADataSet.PHIEUNHAPVATTUPHUTUNG);
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.VATTUPHUTUNG' table. You can move, or remove it, as needed.
            this.vATTUPHUTUNGTableAdapter.Fill(this.qUAN_LY_GARADataSet.VATTUPHUTUNG);
            RefreshText();
            ResetTextBox();
            txtDonGia.KeyPress += KeyPress_Even.So;
            txtSoLuong.KeyPress += KeyPress_Even.So;

        }
        private void ThemVatTuPhuTung()
        {
            var vt = new DATA.Info.PhieuNhapVatTuPhuTung();
            try
            {
                vt.DonGia = double.Parse(txtDonGia.Text);
                vt.MaVatTu = cbMaVTPT.Text;
                vt.NgayNhap = dateNgayNhap.Text;
                vt.SoLuong = int.Parse(txtSoLuong.Text);
                vt.TenVatTu = txtTenVTPT.Text;
                vt.ThanhTien = vt.DonGia * vt.SoLuong;
                vt.MaPhieuNhap = cbMaPhieu.Text;
                PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_Insert(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phiếu nhập đã tồn tại vật tư này!","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void CapNhatVatTuPhuTung()
        {
            var vt = new DATA.Info.PhieuNhapVatTuPhuTung();
            try
            {
                vt.DonGia = double.Parse(txtDonGia.Text);
                vt.SoLuong = int.Parse(txtSoLuong.Text);
                vt.MaPhieuNhap = cbMaPhieu.Text;
                vt.MaVatTu = cbMaVTPT.Text;
                PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_Update(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void XoaVatTuPhuTung()
        {
            var vt = new DATA.Info.PhieuNhapVatTuPhuTung();
            try
            {
                vt.MaPhieuNhap = tableDSVTPT.CurrentRow.Cells[0].Value.ToString();
                vt.MaVatTu = tableDSVTPT.CurrentRow.Cells[1].Value.ToString();
                PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_Delete(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemTraTextBox()
        {
            if (txtDonGia.Text == "") return false;
            if (txtSoLuong.Text == "") return false;
            if (txtTenVTPT.Text == "") return false;
            if (cbMaVTPT.Text == "") return false;
            return true;
        }
        private void ResetTextBox()
        {
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            tableDSVTPT.DataSource = PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_GetPhieuNhapVatTuPhuTung(cbMaPhieu.Text);
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTextBox()) btnThemMoi.Enabled = true;
                else btnThemMoi.Enabled = false;
                if (txtSoLuong.Text != "" && txtDonGia.Text!="") txtThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemVatTuPhuTung();
            ResetTextBox();
            ResetButtom();
        }
        private void ResetButtom()
        {
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }
        private void cbMaVTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshText();
        }
        private void RefreshText()
        {
            txtTenVTPT.Text = VatTuPhuTungBUS.VatTuPhuTung_ReturnTenVatTu(cbMaVTPT.Text);
        }

        private void PhieuMoi_Click(object sender, EventArgs e)
        {
            cbMaPhieu.DataSource = PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_GetNewID();
            cbMaPhieu.DisplayMember = "SoPhieuNhap";
            cbMaPhieu.ValueMember = "SoPhieuNhap";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaVatTuPhuTung();
            ResetTextBox();
            ResetButtom();
        }

        private void tableDSVTPT_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void cbMaPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatVatTuPhuTung();
            ResetTextBox();
            ResetButtom();
        }

        private void tableDSVTPT_DoubleClick(object sender, EventArgs e)
        {
            cbMaVTPT.Text = tableDSVTPT.CurrentRow.Cells[1].Value.ToString();
            txtTenVTPT.Text = tableDSVTPT.CurrentRow.Cells[2].Value.ToString();
            dateNgayNhap.Value = DateTime.Parse(tableDSVTPT.CurrentRow.Cells[3].Value.ToString());
            txtSoLuong.Text = tableDSVTPT.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = tableDSVTPT.CurrentRow.Cells[5].Value.ToString();
            txtThanhTien.Text = tableDSVTPT.CurrentRow.Cells[6].Value.ToString();
            btnCapNhat.Enabled = true;
        }
    }
}
