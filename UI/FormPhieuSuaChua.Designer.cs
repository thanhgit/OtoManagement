namespace UI
{
    partial class FormPhieuSuaChua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuSuaChua));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tablePhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbBienSo = new System.Windows.Forms.ComboBox();
            this.xEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARADataSet = new UI.QUAN_LY_GARADataSet();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSoLuongTon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnPhieuMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenVatTu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaPhieu = new System.Windows.Forms.ComboBox();
            this.cbNoiDung = new System.Windows.Forms.ComboBox();
            this.lOAITIENCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMaVatTu = new System.Windows.Forms.ComboBox();
            this.vATTUPHUTUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLapPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.xETableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.XETableAdapter();
            this.vATTUPHUTUNGTableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.VATTUPHUTUNGTableAdapter();
            this.lOAITIENCONGTableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.LOAITIENCONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITIENCONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.tablePhieuSuaChua);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 180);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(780, 141);
            this.panelControl2.TabIndex = 1;
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
            this.MaVT,
            this.SoLuong2,
            this.DonGia2,
            this.NoiDung2,
            this.TienCong2,
            this.NgaySuaChua,
            this.ThanhTien2});
            this.tablePhieuSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePhieuSuaChua.Location = new System.Drawing.Point(2, 2);
            this.tablePhieuSuaChua.Name = "tablePhieuSuaChua";
            this.tablePhieuSuaChua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePhieuSuaChua.Size = new System.Drawing.Size(776, 137);
            this.tablePhieuSuaChua.TabIndex = 2;
            this.tablePhieuSuaChua.Click += new System.EventHandler(this.tablePhieuSuaChua_Click);
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaPhieu.DataPropertyName = "MaPhieuSuaChua";
            this.MaPhieu.Frozen = true;
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            this.MaPhieu.Width = 92;
            // 
            // MaVT
            // 
            this.MaVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaVT.DataPropertyName = "MaVatTu";
            this.MaVT.Frozen = true;
            this.MaVT.HeaderText = "Mã vật tư";
            this.MaVT.Name = "MaVT";
            this.MaVT.ReadOnly = true;
            this.MaVT.Width = 92;
            // 
            // SoLuong2
            // 
            this.SoLuong2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong2.DataPropertyName = "SoLuongVatTu";
            this.SoLuong2.Frozen = true;
            this.SoLuong2.HeaderText = "Số lượng";
            this.SoLuong2.Name = "SoLuong2";
            this.SoLuong2.ReadOnly = true;
            this.SoLuong2.Width = 92;
            // 
            // DonGia2
            // 
            this.DonGia2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonGia2.DataPropertyName = "DonGia";
            this.DonGia2.Frozen = true;
            this.DonGia2.HeaderText = "Đơn giá";
            this.DonGia2.Name = "DonGia2";
            this.DonGia2.ReadOnly = true;
            this.DonGia2.Width = 92;
            // 
            // NoiDung2
            // 
            this.NoiDung2.DataPropertyName = "NoiDungSuaChua";
            this.NoiDung2.HeaderText = "Nội dung sữa chữa";
            this.NoiDung2.Name = "NoiDung2";
            this.NoiDung2.ReadOnly = true;
            // 
            // TienCong2
            // 
            this.TienCong2.DataPropertyName = "DonGia1";
            this.TienCong2.HeaderText = "Tiền công";
            this.TienCong2.Name = "TienCong2";
            this.TienCong2.ReadOnly = true;
            // 
            // NgaySuaChua
            // 
            this.NgaySuaChua.DataPropertyName = "NgaySuaChua";
            this.NgaySuaChua.HeaderText = "Ngày Sửa Chữa";
            this.NgaySuaChua.Name = "NgaySuaChua";
            // 
            // ThanhTien2
            // 
            this.ThanhTien2.DataPropertyName = "ThanhTien";
            this.ThanhTien2.HeaderText = "Thành tiền";
            this.ThanhTien2.Name = "ThanhTien2";
            this.ThanhTien2.ReadOnly = true;
            // 
            // dateNgayTiepNhan
            // 
            this.dateNgayTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateNgayTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTiepNhan.Location = new System.Drawing.Point(602, 15);
            this.dateNgayTiepNhan.Name = "dateNgayTiepNhan";
            this.dateNgayTiepNhan.Size = new System.Drawing.Size(138, 24);
            this.dateNgayTiepNhan.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(53, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 18);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Mã phiếu:";
            // 
            // cbBienSo
            // 
            this.cbBienSo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbBienSo.DataSource = this.xEBindingSource;
            this.cbBienSo.DisplayMember = "BienSo";
            this.cbBienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBienSo.FormattingEnabled = true;
            this.cbBienSo.Location = new System.Drawing.Point(347, 15);
            this.cbBienSo.Name = "cbBienSo";
            this.cbBienSo.Size = new System.Drawing.Size(138, 26);
            this.cbBienSo.TabIndex = 24;
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
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl4.Location = new System.Drawing.Point(41, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 18);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Mã Vật Tư:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl2.Location = new System.Drawing.Point(274, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 18);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Biển số:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl3.Location = new System.Drawing.Point(264, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 18);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Nội dung:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(523, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 18);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(602, 57);
            this.txtSoLuong.MaxLength = 10;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PreventEnterBeep = true;
            this.txtSoLuong.Size = new System.Drawing.Size(77, 24);
            this.txtSoLuong.TabIndex = 31;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(509, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 18);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtThanhTien.Border.Class = "TextBoxBorder";
            this.txtThanhTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(602, 97);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PreventEnterBeep = true;
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(138, 24);
            this.txtThanhTien.TabIndex = 33;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl7.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl7.Location = new System.Drawing.Point(516, 18);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 18);
            this.labelControl7.TabIndex = 34;
            this.labelControl7.Text = "Ngày sửa:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThemMoi.Enabled = false;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(244, 145);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(110, 29);
            this.btnThemMoi.TabIndex = 35;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(397, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 29);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.txtSoLuongTon);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.btnPhieuMoi);
            this.panelControl1.Controls.Add(this.txtTenVatTu);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.cbMaPhieu);
            this.panelControl1.Controls.Add(this.cbNoiDung);
            this.panelControl1.Controls.Add(this.cbMaVatTu);
            this.panelControl1.Controls.Add(this.btnLapPhieu);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnThemMoi);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtThanhTien);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.cbBienSo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dateNgayTiepNhan);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(780, 188);
            this.panelControl1.TabIndex = 0;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtSoLuongTon.Border.Class = "TextBoxBorder";
            this.txtSoLuongTon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuongTon.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(133, 96);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.PreventEnterBeep = true;
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(76, 24);
            this.txtSoLuongTon.TabIndex = 49;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl9.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl9.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl9.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl9.Location = new System.Drawing.Point(30, 99);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(87, 18);
            this.labelControl9.TabIndex = 48;
            this.labelControl9.Text = "Số lượng tồn:";
            // 
            // btnPhieuMoi
            // 
            this.btnPhieuMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhieuMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPhieuMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuMoi.Image")));
            this.btnPhieuMoi.Location = new System.Drawing.Point(224, 14);
            this.btnPhieuMoi.Name = "btnPhieuMoi";
            this.btnPhieuMoi.Size = new System.Drawing.Size(25, 27);
            this.btnPhieuMoi.TabIndex = 47;
            this.btnPhieuMoi.Click += new System.EventHandler(this.btnPhieuMoi_Click);
            // 
            // txtTenVatTu
            // 
            this.txtTenVatTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtTenVatTu.Border.Class = "TextBoxBorder";
            this.txtTenVatTu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenVatTu.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtTenVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVatTu.Location = new System.Drawing.Point(347, 57);
            this.txtTenVatTu.Name = "txtTenVatTu";
            this.txtTenVatTu.PreventEnterBeep = true;
            this.txtTenVatTu.ReadOnly = true;
            this.txtTenVatTu.Size = new System.Drawing.Size(138, 24);
            this.txtTenVatTu.TabIndex = 46;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl8.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl8.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl8.Location = new System.Drawing.Point(244, 57);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 18);
            this.labelControl8.TabIndex = 45;
            this.labelControl8.Text = "Tên Vật Tư:";
            // 
            // cbMaPhieu
            // 
            this.cbMaPhieu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMaPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhieu.FormattingEnabled = true;
            this.cbMaPhieu.Location = new System.Drawing.Point(133, 15);
            this.cbMaPhieu.Name = "cbMaPhieu";
            this.cbMaPhieu.Size = new System.Drawing.Size(81, 26);
            this.cbMaPhieu.TabIndex = 44;
            this.cbMaPhieu.SelectedIndexChanged += new System.EventHandler(this.cbMaPhieu_SelectedIndexChanged);
            // 
            // cbNoiDung
            // 
            this.cbNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbNoiDung.DataSource = this.lOAITIENCONGBindingSource;
            this.cbNoiDung.DisplayMember = "NoiDungSuaChua";
            this.cbNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoiDung.FormattingEnabled = true;
            this.cbNoiDung.Location = new System.Drawing.Point(347, 95);
            this.cbNoiDung.Name = "cbNoiDung";
            this.cbNoiDung.Size = new System.Drawing.Size(138, 26);
            this.cbNoiDung.TabIndex = 43;
            this.cbNoiDung.ValueMember = "NoiDungSuaChua";
            this.cbNoiDung.SelectedIndexChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // lOAITIENCONGBindingSource
            // 
            this.lOAITIENCONGBindingSource.DataMember = "LOAITIENCONG";
            this.lOAITIENCONGBindingSource.DataSource = this.qUAN_LY_GARADataSet;
            // 
            // cbMaVatTu
            // 
            this.cbMaVatTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMaVatTu.DataSource = this.vATTUPHUTUNGBindingSource;
            this.cbMaVatTu.DisplayMember = "MaVatTu";
            this.cbMaVatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaVatTu.FormattingEnabled = true;
            this.cbMaVatTu.Location = new System.Drawing.Point(133, 54);
            this.cbMaVatTu.Name = "cbMaVatTu";
            this.cbMaVatTu.Size = new System.Drawing.Size(81, 26);
            this.cbMaVatTu.TabIndex = 42;
            this.cbMaVatTu.ValueMember = "MaVatTu";
            this.cbMaVatTu.SelectedIndexChanged += new System.EventHandler(this.cbMaVatTu_SelectedIndexChanged);
            // 
            // vATTUPHUTUNGBindingSource
            // 
            this.vATTUPHUTUNGBindingSource.DataMember = "VATTUPHUTUNG";
            this.vATTUPHUTUNGBindingSource.DataSource = this.qUAN_LY_GARADataSet;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.Image")));
            this.btnLapPhieu.Location = new System.Drawing.Point(516, 142);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(98, 32);
            this.btnLapPhieu.TabIndex = 41;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // vATTUPHUTUNGTableAdapter
            // 
            this.vATTUPHUTUNGTableAdapter.ClearBeforeFill = true;
            // 
            // lOAITIENCONGTableAdapter
            // 
            this.lOAITIENCONGTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(780, 321);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuSuaChua";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormPhieuSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITIENCONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView tablePhieuSuaChua;
        private System.Windows.Forms.DateTimePicker dateNgayTiepNhan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbBienSo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieu;
        private System.Windows.Forms.ComboBox cbMaVatTu;
        private System.Windows.Forms.ComboBox cbNoiDung;
        private QUAN_LY_GARADataSet qUAN_LY_GARADataSet;
        private System.Windows.Forms.BindingSource xEBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.XETableAdapter xETableAdapter;
        private System.Windows.Forms.ComboBox cbMaPhieu;
        private System.Windows.Forms.BindingSource vATTUPHUTUNGBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.VATTUPHUTUNGTableAdapter vATTUPHUTUNGTableAdapter;
        private System.Windows.Forms.BindingSource lOAITIENCONGBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.LOAITIENCONGTableAdapter lOAITIENCONGTableAdapter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnPhieuMoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuongTon;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien2;


    }
}