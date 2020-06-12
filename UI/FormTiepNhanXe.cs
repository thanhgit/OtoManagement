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
    public partial class FormTiepNhanXe : Form
    {
        public FormTiepNhanXe()
        {
            InitializeComponent();
            dateNgayTiepNhan.Format = DateTimePickerFormat.Custom;
            dateNgayTiepNhan.CustomFormat = "yyyy/MM/dd";
        }

        private void FormTiepNhanXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.HIEUXE' table. You can move, or remove it, as needed.
            this.hIEUXETableAdapter.Fill(this.qUAN_LY_GARADataSet.HIEUXE);
            tableTiepNhanXe.DataSource = XeBUS.Xe_GetAll();
            ResetTextBox();
            txtToiDa.Text = ThamSoBUS.ThamSo_Get().ToString();
            SetEvenTextBox();          
        }
        private void SetEvenTextBox()
        {
            txtToiDa.KeyPress += KeyPress_Even.So;
            txtBienSo.KeyPress += KeyPress_Even.BienSo;
            txtDienThoai.KeyPress += KeyPress_Even.So;
            txtEmail.KeyPress += KeyPress_Even.Email;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtDaNhan.Text) > int.Parse(txtToiDa.Text))
            {
                MessageBox.Show("Lượng tiếp nhận hôm nay đã hết!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ThemXe();
            ResetTextBox();
            ResetButon();
        }
        private void ThemXe()
        {
            var xe = new DATA.Info.Xe();
            try
            {
                xe.TenChuXe = txtTenChuXe.Text;
                xe.BienSo = txtBienSo.Text;
                xe.DiaChi = txtDiaChi.Text;
                xe.Email = txtEmail.Text;
                xe.DienThoai = txtDienThoai.Text;
                xe.HieuXe = cbHieuXe.SelectedValue.ToString();
                xe.NgayTiepNhan = dateNgayTiepNhan.Text;
                XeBUS.Xe_Insert(xe);
                tableTiepNhanXe.DataSource = XeBUS.Xe_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatXe()
        {
            var xe = new DATA.Info.Xe();
            try
            {
                xe.TenChuXe = txtTenChuXe.Text;
                xe.BienSo = txtBienSo.Text;
                xe.DiaChi = txtDiaChi.Text;
                xe.Email = txtEmail.Text;
                xe.DienThoai = txtDienThoai.Text;
                xe.HieuXe = cbHieuXe.SelectedValue.ToString();
                xe.NgayTiepNhan = dateNgayTiepNhan.Text;
                XeBUS.Xe_Update(xe);
                tableTiepNhanXe.DataSource = XeBUS.Xe_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void XoaXe()
        {
            try
            {
                string BienSo = tableTiepNhanXe.CurrentRow.Cells[0].Value.ToString();
                XeBUS.Xe_Delete(BienSo);
                tableTiepNhanXe.DataSource = XeBUS.Xe_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetTextBox()
        {
            txtBienSo.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtTenChuXe.Text = "";
            try
            {
                txtDaNhan.Text = XeBUS.Xe_GetSoLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBienSo_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraTextBox()) btnThemMoi.Enabled = true;
            else btnThemMoi.Enabled = false;
        }
        private bool KiemTraTextBox()
        {
            if (txtBienSo.Text == "") return false;
            if (txtDiaChi.Text == "") return false;
            if (txtDienThoai.Text == "") return false;
            if (txtEmail.Text == "") return false;
            if (txtTenChuXe.Text == "") return false;
            return true;
        }

        private void tableTiepNhanXe_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void tableTiepNhanXe_DoubleClick(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            txtBienSo.Text = tableTiepNhanXe.CurrentRow.Cells[0].Value.ToString();
            txtTenChuXe.Text = tableTiepNhanXe.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = tableTiepNhanXe.CurrentRow.Cells[3].Value.ToString();
            txtDienThoai.Text = tableTiepNhanXe.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = tableTiepNhanXe.CurrentRow.Cells[5].Value.ToString();
            cbHieuXe.Text = tableTiepNhanXe.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CapNhatXe();
            ResetTextBox();
            ResetButon();
        }
        private void ResetButon()
        {
            btnCapNhat.Enabled = false;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaXe();
            ResetTextBox();
            ResetButon();
        }

        private void txtToiDa_Leave(object sender, EventArgs e)
        {
            if (txtToiDa.Text == "")
            {
                txtToiDa.Text = ThamSoBUS.ThamSo_Get().ToString();
                return;
            }
            ThamSoBUS.ThamSo_Set(int.Parse(txtToiDa.Text));
        }
    }
}
