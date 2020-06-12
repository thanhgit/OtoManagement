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
using DATA;
using BUS;

namespace UI
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();

        }
        private void SetEvenTextBox()
        {
            boxDangNhap.KeyPress += KeyPress_Even.Email;
            boxMatKhau.KeyPress += KeyPress_Even.Email;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var check = new DATA.Info.TaiKhoan();
                check.TenTruyCap = boxDangNhap.Text;
                check.MatKhau = boxMatKhau.Text;
                if (TaiKhoanBUS.TaiKhoan_CHECK(check))
                {
                    DATA.Info.NhanVien.MaNV = TaiKhoanBUS.TaiKhoan_GetNV(check);
                    DATA.Info.NhanVien.PermissionID = TaiKhoanBUS.TaiKhoan_GetID(check);
                    MainForm frmMain = new MainForm();
                    frmMain.Show();
                    this.Visible = false;

                }
                else
                {
                    Loi.Text = "Sai tài khoản hoặc mất khẩu!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Boolean flag;
        private int x, y;
        private void _MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }
        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        private void _MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            SetEvenTextBox();
        }
    }
}