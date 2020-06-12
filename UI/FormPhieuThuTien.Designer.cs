namespace UI
{
    partial class FormPhieuThuTien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuThuTien));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtConLai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoTienThu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayThuTien = new System.Windows.Forms.DateTimePicker();
            this.cbBienSo = new System.Windows.Forms.ComboBox();
            this.xEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARADataSet = new UI.QUAN_LY_GARADataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xETableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.XETableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tablePhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.txtMaNhanVien);
            this.panelControl2.Controls.Add(this.txtTenNhanVien);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtConLai);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txtSoTienThu);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.btnThemMoi);
            this.panelControl2.Controls.Add(this.btnLapPhieu);
            this.panelControl2.Controls.Add(this.txtTongTien);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.dateNgayThuTien);
            this.panelControl2.Controls.Add(this.cbBienSo);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(752, 192);
            this.panelControl2.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(331, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 29);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaNhanVien
            // 
            // 
            // 
            // 
            this.txtMaNhanVien.Border.Class = "TextBoxBorder";
            this.txtMaNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(500, 12);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PreventEnterBeep = true;
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(138, 24);
            this.txtMaNhanVien.TabIndex = 61;
            // 
            // txtTenNhanVien
            // 
            // 
            // 
            // 
            this.txtTenNhanVien.Border.Class = "TextBoxBorder";
            this.txtTenNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(500, 56);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PreventEnterBeep = true;
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(138, 24);
            this.txtTenNhanVien.TabIndex = 58;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(382, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 18);
            this.labelControl6.TabIndex = 57;
            this.labelControl6.Text = "Tên Nhân Viên:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(388, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 18);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "Mã Nhân Viên:";
            // 
            // txtConLai
            // 
            // 
            // 
            // 
            this.txtConLai.Border.Class = "TextBoxBorder";
            this.txtConLai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConLai.Location = new System.Drawing.Point(591, 102);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.PreventEnterBeep = true;
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(116, 24);
            this.txtConLai.TabIndex = 54;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl4.Location = new System.Drawing.Point(533, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 18);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Còn Lại:\r\n";
            // 
            // txtSoTienThu
            // 
            // 
            // 
            // 
            this.txtSoTienThu.Border.Class = "TextBoxBorder";
            this.txtSoTienThu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoTienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienThu.Location = new System.Drawing.Point(402, 100);
            this.txtSoTienThu.MaxLength = 18;
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.PreventEnterBeep = true;
            this.txtSoTienThu.Size = new System.Drawing.Size(109, 24);
            this.txtSoTienThu.TabIndex = 52;
            this.txtSoTienThu.TextChanged += new System.EventHandler(this.txtSoTienThu_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl3.Location = new System.Drawing.Point(321, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Số tiền thu:\r\n";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Enabled = false;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(210, 143);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(95, 32);
            this.btnThemMoi.TabIndex = 50;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.Image")));
            this.btnLapPhieu.Location = new System.Drawing.Point(449, 143);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(95, 32);
            this.btnLapPhieu.TabIndex = 48;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // txtTongTien
            // 
            // 
            // 
            // 
            this.txtTongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongTien.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(167, 102);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PreventEnterBeep = true;
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(117, 18);
            this.txtTongTien.TabIndex = 47;
            this.txtTongTien.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl9.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl9.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl9.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl9.Location = new System.Drawing.Point(58, 102);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 18);
            this.labelControl9.TabIndex = 46;
            this.labelControl9.Text = "Số tiền cần thu:\r\n";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl7.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl7.Location = new System.Drawing.Point(55, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 18);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "Ngày thu tiền:";
            // 
            // dateNgayThuTien
            // 
            this.dateNgayThuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayThuTien.Location = new System.Drawing.Point(167, 58);
            this.dateNgayThuTien.Name = "dateNgayThuTien";
            this.dateNgayThuTien.Size = new System.Drawing.Size(138, 24);
            this.dateNgayThuTien.TabIndex = 44;
            // 
            // cbBienSo
            // 
            this.cbBienSo.DataSource = this.xEBindingSource;
            this.cbBienSo.DisplayMember = "BienSo";
            this.cbBienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBienSo.FormattingEnabled = true;
            this.cbBienSo.Location = new System.Drawing.Point(167, 11);
            this.cbBienSo.Name = "cbBienSo";
            this.cbBienSo.Size = new System.Drawing.Size(138, 26);
            this.cbBienSo.TabIndex = 41;
            this.cbBienSo.ValueMember = "BienSo";
            this.cbBienSo.SelectedIndexChanged += new System.EventHandler(this.cbBienSo_SelectedIndexChanged);
            // 
            // xEBindingSource
            // 
            this.xEBindingSource.DataMember = "XE";
            this.xEBindingSource.DataSource = this.qUAN_LY_GARADataSet;
            // 
            // qUAN_LY_GARADataSet
            // 
            this.qUAN_LY_GARADataSet.DataSetName = "QUAN_LY_GARADataSet";
            this.qUAN_LY_GARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(96, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 18);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Biển số:";
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tablePhieuSuaChua);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 192);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(752, 106);
            this.panelControl1.TabIndex = 2;
            // 
            // tablePhieuSuaChua
            // 
            this.tablePhieuSuaChua.AllowUserToOrderColumns = true;
            this.tablePhieuSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePhieuSuaChua.BackgroundColor = System.Drawing.Color.White;
            this.tablePhieuSuaChua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhieuSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaNV,
            this.TenNhanVien,
            this.SoTienThu,
            this.NgayThuTien});
            this.tablePhieuSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePhieuSuaChua.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.tablePhieuSuaChua.Location = new System.Drawing.Point(2, 2);
            this.tablePhieuSuaChua.Name = "tablePhieuSuaChua";
            this.tablePhieuSuaChua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePhieuSuaChua.Size = new System.Drawing.Size(748, 102);
            this.tablePhieuSuaChua.TabIndex = 3;
            this.tablePhieuSuaChua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePhieuSuaChua_CellContentClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieuThuTien";
            this.MaPhieu.HeaderText = "Mã phiếu thu tiền";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNV";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // SoTienThu
            // 
            this.SoTienThu.DataPropertyName = "SoTienThu";
            this.SoTienThu.HeaderText = "Số tiền thu";
            this.SoTienThu.Name = "SoTienThu";
            // 
            // NgayThuTien
            // 
            this.NgayThuTien.DataPropertyName = "NgayThuTien";
            this.NgayThuTien.HeaderText = "Ngày thu tiền";
            this.NgayThuTien.Name = "NgayThuTien";
            // 
            // FormPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 298);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuThuTien";
            this.Text = "FormPhieuThuTien";
            this.Load += new System.EventHandler(this.FormPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cbBienSo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DateTimePicker dateNgayThuTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieu;
        private QUAN_LY_GARADataSet qUAN_LY_GARADataSet;
        private System.Windows.Forms.BindingSource xEBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.XETableAdapter xETableAdapter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtConLai;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoTienThu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView tablePhieuSuaChua;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThuTien;
    }
}