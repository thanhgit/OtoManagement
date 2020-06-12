using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DATA.Info;
using BUS;

namespace UI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            loadformTrangChu();
            label1.Text = "Thông tin nhân viên";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ResetLabel();
            Label label = (Label)sender;
            label.ForeColor = Color.Turquoise;
            label.Tag = 1;
            if (label.Text == "Tiếp nhận xe")
            {
                loadformTiepNhanXe();
            }
            if (label.Text == "Phiếu thu tiền")
            {
                loadformPhieuThuTien();
            }
            if (label.Text == "Quản lý hiệu xe")
            {
                loadformQLHieuXe();
            }
            if (label.Text == "Phiếu sửa chữa")
            {
                loadformPhieuSuaChua();
            }
            if (label.Text == "Quản lý tiền công")
            {
                loadformQLTienCong();
            }
            if (label.Text == "Quản lý vật tư phụ tùng")
            {
                loadformQLVatTu();
            }
            if (label.Text == "Báo cáo doanh số")
            {
                loadformBCDoanhSo();
            }
            if (label.Text == "Báo cáo tồn")
            {
                loadformBCTon();
            }
            if (label.Text == "Thông tin nhân viên")
            {
                loadThongTinNhanVien();
            }
        }
        private void loadformTiepNhanXe()
        {
            FormTiepNhanXe frm = new FormTiepNhanXe() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformPhieuThuTien()
        {
            FormPhieuThuTien frm = new FormPhieuThuTien() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformPhieuSuaChua()
        {
            FormPhieuSuaChua frm = new FormPhieuSuaChua() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Turquoise;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Tag.ToString() == "1") return;
            label.ForeColor = Color.DarkSlateGray;
        }

        private void QuanLyTNXButton_Click(object sender, EventArgs e)
        {
            labelX1.Text = "Quản lý tiếp nhận xe";
            VisibleLabel();
            label2.Visible = false;
            label3.Visible = false;
            label1.Text = "Tiếp nhận xe";
            label1.ForeColor = Color.Turquoise;
            loadformTiepNhanXe();
        }

        private void HoaDonKDButton_Click(object sender, EventArgs e)
        {
            labelX1.Text = "Hóa đơn kinh doanh";
            VisibleLabel();
            label3.Visible = false;
            label1.Text = "Phiếu thu tiền";
            label2.Text = "Phiếu sửa chữa";
            label1.ForeColor = Color.Turquoise;
            loadformPhieuThuTien();
        }
        private void VisibleLabel()
        {
            ResetLabel();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void QuanLyCSButton_Click(object sender, EventArgs e)
        {
            labelX1.Text = "Quản lý cơ sở vật chất";
            VisibleLabel();
            label1.Text = "Quản lý hiệu xe";
            label3.Text = "Quản lý vật tư phụ tùng";
            label2.Text = "Quản lý tiền công";
            label1.ForeColor = Color.Turquoise;
            loadformQLHieuXe();
        }

        private void BaoCaoKDButton_Click(object sender, EventArgs e)
        {
            labelX1.Text = "Báo cáo kinh doanh tháng";
            VisibleLabel();
            label3.Visible = false;
            label2.Text = "Báo cáo doanh số";
            label1.Text = "Báo cáo tồn";
            label1.ForeColor = Color.Turquoise;
            loadformBCTon();
        }

        private void TraCuuButton_Click(object sender, EventArgs e)
        {
            labelX1.Text = "Tra cứu thông tin xe đã tiếp nhập";
            label1.Text = "Tra cứu thông tin";
            label2.Visible = false;
            label3.Visible = false;
            label1.ForeColor = Color.Turquoise;
            loadformTimKiem();
        }
        private void loadformTimKiem()
        {
            FormTimKiem frm = new FormTimKiem() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformQLTienCong()
        {
            FormQLTienCong frm = new FormQLTienCong() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadThongTinNhanVien()
        {
            FormThongTinNhanVien frm = new FormThongTinNhanVien() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformQLHieuXe()
        {
            FormQLHieuXe frm = new FormQLHieuXe() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformQLVatTu()
        {
            FormQLVatTu frm = new FormQLVatTu() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformBCTon()
        {
            FormBCTon frm = new FormBCTon() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformBCDoanhSo()
        {
            FormBCDoanhSo frm = new FormBCDoanhSo() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }
        private void loadformTrangChu()
        {
            labelX1.Text = TaiKhoanBUS.GetTenNhanVien()+"                       Chức vụ: "+TaiKhoanBUS.GetMoTa();
            FormTrangChu frm = new FormTrangChu() { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            superTabItem1.AttachedControl.Controls.Clear();
            superTabItem1.AttachedControl.Controls.Add(frm);
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrangChuButton_Click(object sender, EventArgs e)
        {
            VisibleLabel();
            label1.Text = "Thông tin nhân viên";
            label2.Visible = false;
            label3.Visible = false;
            loadformTrangChu();
        }
        private void ResetLabel()
        {
            label1.ForeColor = Color.DarkSlateGray;
            label2.ForeColor = Color.DarkSlateGray;
            label3.ForeColor = Color.DarkSlateGray;
            label1.Tag = 0;
            label2.Tag = 0;
            label3.Tag = 0;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là phần mềm được làm bởi nhóm 13 \nmôn Nhập Môn Công Nghệ Phần Mềm\ndo giáo viên Nguyễn Công Hoan đảm nhiệm.\nNhóm 13 gồm 4 thành viên:\nHà Thanh Tuấn(Leader)\nBùi Văn Duy\nĐỗ Quang Khánh\nPhạm Phước Hạnh\n", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.SetDesktopLocation(Cursor.Position.X - x - 206, Cursor.Position.Y - y);
            }
        }
        private void _MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}