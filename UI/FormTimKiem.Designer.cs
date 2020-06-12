namespace UI
{
    partial class FormTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimKiem));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbChuanTimKiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.table_DanhSach = new System.Windows.Forms.DataGridView();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ĐienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbChuanTimKiem);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cb_TimKiem);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(842, 73);
            this.panelControl1.TabIndex = 0;
            // 
            // cbChuanTimKiem
            // 
            this.cbChuanTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuanTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuanTimKiem.FormattingEnabled = true;
            this.cbChuanTimKiem.Items.AddRange(new object[] {
            "Hiệu xe",
            "Tên chủ xe",
            "Biển số"});
            this.cbChuanTimKiem.Location = new System.Drawing.Point(166, 27);
            this.cbChuanTimKiem.Name = "cbChuanTimKiem";
            this.cbChuanTimKiem.Size = new System.Drawing.Size(122, 24);
            this.cbChuanTimKiem.TabIndex = 46;
            this.cbChuanTimKiem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuẩn tìm kiếm:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Thông tin tìm kiếm: ";
            // 
            // cb_TimKiem
            // 
            this.cb_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TimKiem.DisplayMember = "HieuXe";
            this.cb_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimKiem.FormattingEnabled = true;
            this.cb_TimKiem.Location = new System.Drawing.Point(405, 28);
            this.cb_TimKiem.Name = "cb_TimKiem";
            this.cb_TimKiem.Size = new System.Drawing.Size(202, 21);
            this.cb_TimKiem.TabIndex = 44;
            this.cb_TimKiem.TabStop = false;
            this.cb_TimKiem.ValueMember = "HieuXe";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(631, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 27);
            this.btnTimKiem.TabIndex = 43;
            this.btnTimKiem.Text = "Tìm\r\n";
            this.btnTimKiem.Click += new System.EventHandler(this.TimKiembuttom_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCapNhat);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 292);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(842, 46);
            this.panelControl2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(363, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(114, 36);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập nhật\r\n";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.table_DanhSach);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 73);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(842, 213);
            this.panelControl3.TabIndex = 1;
            // 
            // table_DanhSach
            // 
            this.table_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_DanhSach.BackgroundColor = System.Drawing.Color.White;
            this.table_DanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.HieuXe,
            this.Ten,
            this.ĐienThoai,
            this.DiaChi,
            this.Email,
            this.Ngay,
            this.TienNo});
            this.table_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_DanhSach.Location = new System.Drawing.Point(2, 2);
            this.table_DanhSach.Name = "table_DanhSach";
            this.table_DanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.table_DanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_DanhSach.Size = new System.Drawing.Size(838, 209);
            this.table_DanhSach.TabIndex = 2;
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // HieuXe
            // 
            this.HieuXe.DataPropertyName = "HieuXe";
            this.HieuXe.HeaderText = "Hiệu xe";
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TenChuXe";
            this.Ten.HeaderText = "Tên chủ xe";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // ĐienThoai
            // 
            this.ĐienThoai.DataPropertyName = "DienThoai";
            this.ĐienThoai.HeaderText = "Điện thoại";
            this.ĐienThoai.Name = "ĐienThoai";
            this.ĐienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NgayTiepNhan";
            this.Ngay.HeaderText = "Ngày tiếp nhận";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "TienNo";
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 338);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.ComboBox cbChuanTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView table_DanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ĐienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
    }
}