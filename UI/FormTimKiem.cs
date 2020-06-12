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

namespace UI
{
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
            DataGV = table_DanhSach;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChuanTimKiem.Text == "Biển số")
            {
                SelectedBienSo();
            }
            if (cbChuanTimKiem.Text == "Hiệu xe")
            {
                SelectedHieuXe();
            }
            if (cbChuanTimKiem.Text == "Tên chủ xe")
            {
                SelectedTenChuXe();
            }
        }
        private void SelectedBienSo()
        {
            cb_TimKiem.DataSource = XeBUS.Xe_GetBienSo();
            cb_TimKiem.DisplayMember = "BienSo";
            cb_TimKiem.ValueMember = "BienSo";
        }
        private void SelectedHieuXe()
        {
            cb_TimKiem.DataSource = XeBUS.Xe_GetHieuXe();
            cb_TimKiem.DisplayMember = "HieuXe";
            cb_TimKiem.ValueMember = "HieuXe";
        }
        private void SelectedTenChuXe()
        {
            cb_TimKiem.DataSource = XeBUS.Xe_GetTenChuXe();
            cb_TimKiem.DisplayMember = "TenChuXe";
            cb_TimKiem.ValueMember = "TenChuXe";
        }

        private void TimKiembuttom_Click(object sender, EventArgs e)
        {
            cbBox = cbChuanTimKiem.Text;
            cbTimKiem = cb_TimKiem.Text;
            UpdateData();
        }
        public static string cbBox;
        public static string cbTimKiem;
        public static DataGridView DataGV;
        public static void UpdateData()
        {
            if (cbBox == "Biển số")
            {
                DataGV.DataSource = XeBUS.Xe_GetLikeBienSo(cbTimKiem);
            }
            if (cbBox == "Hiệu xe")
            {
                DataGV.DataSource = XeBUS.Xe_GetLikeHieuXe(cbTimKiem);
            }
            if (cbBox == "Tên chủ xe")
            {
                DataGV.DataSource = XeBUS.Xe_GetLikeTenChuXe(cbTimKiem);
            }
        }
        private void ChonXe(DATA.Info.Xe xe)
        {
            xe.TenChuXe = table_DanhSach.CurrentRow.Cells[2].Value.ToString();
            xe.BienSo = table_DanhSach.CurrentRow.Cells[0].Value.ToString();
            xe.DiaChi = table_DanhSach.CurrentRow.Cells[3].Value.ToString();
            xe.Email = table_DanhSach.CurrentRow.Cells[5].Value.ToString();
            xe.DienThoai = table_DanhSach.CurrentRow.Cells[4].Value.ToString();
            xe.HieuXe = table_DanhSach.CurrentRow.Cells[1].Value.ToString();
            xe.NgayTiepNhan = table_DanhSach.CurrentRow.Cells[6].Value.ToString();
            xe.TienNo = double.Parse(table_DanhSach.CurrentRow.Cells[7].Value.ToString());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var xe = new DATA.Info.Xe();
                ChonXe(xe);
                var frm = new FormCapNhatTimKiem(xe);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu rỗng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
