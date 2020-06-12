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
using DATA.Info;
using BUS;

namespace UI
{
    public partial class FormCapNhatTimKiem : DevExpress.XtraEditors.XtraForm
    {
        public FormCapNhatTimKiem(Xe Data)
        {            
            InitializeComponent();
            xe = Data;
        }
        private Xe xe;
        private void FormCapNhatTimKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARADataSet.HIEUXE' table. You can move, or remove it, as needed.
            this.hIEUXETableAdapter.Fill(this.qUAN_LY_GARADataSet.HIEUXE);
            LoadData();
            SetEvenTextBox();
        }
        private void SetEvenTextBox()
        {
            txtDienThoai.KeyPress += KeyPress_Even.So;
            txtEmail.KeyPress += KeyPress_Even.Email;
            txtTienNo.KeyPress += KeyPress_Even.So;
        }
        private void LoadData()
        {
            txtBienSo.Text = xe.BienSo;
            txtTenChuXe.Text = xe.TenChuXe;
            txtDiaChi.Text = xe.DiaChi;
            txtDienThoai.Text = xe.DienThoai;
            txtEmail.Text = xe.Email;
            cbHieuXe.Text = xe.HieuXe;
            dateNgayTiepNhan.Value = DateTime.Parse(xe.NgayTiepNhan);
            txtTienNo.Text = xe.TienNo.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatXe();
        }
        private void CapNhatXe()
        {
            try
            {
                xe.TenChuXe = txtTenChuXe.Text;
                xe.BienSo = txtBienSo.Text;
                xe.DiaChi = txtDiaChi.Text;
                xe.Email = txtEmail.Text;
                xe.DienThoai = txtDienThoai.Text;
                xe.HieuXe = cbHieuXe.SelectedValue.ToString();
                xe.NgayTiepNhan = dateNgayTiepNhan.Text;
                xe.TienNo = int.Parse(txtTienNo.Text);
                XeBUS.Xe_Update(xe);
                FormTimKiem.UpdateData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}