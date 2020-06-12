using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA.Info;
using BUS;

namespace UI
{
    public partial class FormThongTinNhanVien : Form
    {
        public FormThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            txtTen.Text = TaiKhoanBUS.GetTenNhanVien();
            txtMa.Text = NhanVien.MaNV;
            txtChucVu.Text = TaiKhoanBUS.GetMoTa();
            txtDiaChi.Text = TaiKhoanBUS.GetDiaChi();
            txtEmail.Text = TaiKhoanBUS.GetEmail();
            txtSDT.Text = TaiKhoanBUS.GetSDT();
            txtPhong.Text = TaiKhoanBUS.GetPhongBan();
        }
    }
}
