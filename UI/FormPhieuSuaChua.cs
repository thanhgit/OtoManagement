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
    public partial class FormPhieuSuaChua : Form
    {
        public FormPhieuSuaChua()
        {
            InitializeComponent();
        }

        private void FormPhieuSuaChua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.LOAITIENCONG' table. You can move, or remove it, as needed.
            this.lOAITIENCONGTableAdapter.Fill(this.qUAN_LY_GARADataSet.LOAITIENCONG);
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.VATTUPHUTUNG' table. You can move, or remove it, as needed.
            this.vATTUPHUTUNGTableAdapter.Fill(this.qUAN_LY_GARADataSet.VATTUPHUTUNG);
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.XE' table. You can move, or remove it, as needed.
            this.xETableAdapter.Fill(this.qUAN_LY_GARADataSet.XE);
            CapNhatMaPhieuSuaChua();
            txtSoLuong.KeyPress += KeyPress_Even.So;
        }

        private void cbBienSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatMaPhieuSuaChua();
            //tablePhieuSuaChua.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetPhieuSuaChua(cbBienSo.Text, cbMaPhieu.Text);
            if (cbMaPhieu.Text == "")
            {
                MessageBox.Show("Chưa có phiếu sửa chữa!");
            }
            ResetButtom();
        }
        private void CapNhatMaPhieuSuaChua()
        {
            cbMaPhieu.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetMaPhieuSuaChua(cbBienSo.Text);
            cbMaPhieu.DisplayMember = "MaPhieuSuaChua";
            cbMaPhieu.ValueMember = "MaPhieuSuaChua";
            txtTenVatTu.Text = VatTuPhuTungBUS.VatTuPhuTung_ReturnTenVatTu(cbMaVatTu.Text);
            txtSoLuongTon.Text = VatTuPhuTungBUS.VatTuPhuTung_ReturnTonKho(cbMaVatTu.Text).ToString();
            CapNhatThanhTien();
            tablePhieuSuaChua.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetPhieuSuaChua(cbBienSo.Text, cbMaPhieu.Text);
        }
        private void cbMaVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenVatTu.Text = VatTuPhuTungBUS.VatTuPhuTung_ReturnTenVatTu(cbMaVatTu.Text);
            txtSoLuongTon.Text = VatTuPhuTungBUS.VatTuPhuTung_ReturnTonKho(cbMaVatTu.Text).ToString();
            CapNhatThanhTien();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }
        private void CapNhatThanhTien()
        {
            if (txtSoLuong.Text == "")
            {
                btnThemMoi.Enabled = false;
                txtThanhTien.Text = "";
                return;
            }
            btnThemMoi.Enabled = true;
            try
            {
                double DonGia = VatTuPhuTungBUS.VatTuPhuTung_ReturnDonGia(cbMaVatTu.Text);
                double TienCong = LoaiTienCongBUS.LoaiTienCong_GetDonGia(cbNoiDung.Text);
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * DonGia + TienCong).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoLuong.Text) > int.Parse(txtSoLuongTon.Text))
            {
                MessageBox.Show("Số lượng trong kho không đủ!","Cảnh Báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            ThemPhieuSuaChua();
            ResetButtom();
        }
        private void ThemPhieuSuaChua()
        {
            try
            {
                var psc = new DATA.Info.PhieuSuaChua();
                psc.MaPhieuSuaChua = cbMaPhieu.Text;
                psc.MaVatTu = cbMaVatTu.Text;
                psc.NoiDung = cbNoiDung.Text;
                psc.BienSo = cbBienSo.Text;
                psc.SoLuong = int.Parse(txtSoLuong.Text);
                PhieuSuaChuaBUS.PhieuSuaChua_Insert(psc);
                tablePhieuSuaChua.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetPhieuSuaChua(cbBienSo.Text, cbMaPhieu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vật tư đã tồn tại trong phiếu sửa chữa!","Chú ý!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        private void ResetButtom()
        {
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            ResertTextBox();
        }
        private void ResertTextBox()
        {
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            txtSoLuongTon.Text = VatTuPhuTungBUS.VatTuPhuTung_ReturnTonKho(cbMaVatTu.Text).ToString();
        }

        private void tablePhieuSuaChua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }
        private void XoaPhieuSuaChua()
        {
            var psc = new DATA.Info.PhieuSuaChua();
            try
            {
                psc.MaPhieuSuaChua = tablePhieuSuaChua.CurrentRow.Cells[0].Value.ToString();
                psc.MaVatTu = tablePhieuSuaChua.CurrentRow.Cells[1].Value.ToString();
                psc.NoiDung = tablePhieuSuaChua.CurrentRow.Cells[4].Value.ToString();
                PhieuSuaChuaBUS.PhieuSuaChua_Delete(psc);
                tablePhieuSuaChua.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetPhieuSuaChua(cbBienSo.Text, cbMaPhieu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPhieuSuaChua();
            btnXoa.Enabled = false;
        }

        private void btnPhieuMoi_Click(object sender, EventArgs e)
        {
            try
            {
                cbMaPhieu.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_NewID(cbBienSo.Text);
                cbMaPhieu.DisplayMember = "MaPhieuSuaChua";
                cbMaPhieu.ValueMember = "MaPhieuSuaChua";
                MessageBox.Show("Đã tạo thêm một phiếu sửa chữa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            var frm = new BaoCaoSuaChua(cbMaPhieu.Text);
            frm.ShowDialog();
        }

        private void cbMaPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablePhieuSuaChua.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetPhieuSuaChua(cbBienSo.Text, cbMaPhieu.Text);
        }
    }
}
