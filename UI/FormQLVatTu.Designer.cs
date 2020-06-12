namespace UI
{
    partial class FormQLVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLVatTu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.cbMaPhieu = new System.Windows.Forms.ComboBox();
            this.pHIEUNHAPVATTUPHUTUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARADataSet = new UI.QUAN_LY_GARADataSet();
            this.PhieuMoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaVTPT = new System.Windows.Forms.ComboBox();
            this.vATTUPHUTUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenVTPT = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tableDSVTPT = new System.Windows.Forms.DataGridView();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavattuphutung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvattuphutung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATTUPHUTUNGTableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.VATTUPHUTUNGTableAdapter();
            this.pHIEUNHAPVATTUPHUTUNGTableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.PHIEUNHAPVATTUPHUTUNGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPVATTUPHUTUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDSVTPT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCapNhat);
            this.panelControl1.Controls.Add(this.cbMaPhieu);
            this.panelControl1.Controls.Add(this.PhieuMoi);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.cbMaVTPT);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtThanhTien);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.dateNgayNhap);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnThemMoi);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(this.txtDonGia);
            this.panelControl1.Controls.Add(this.txtTenVTPT);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(726, 186);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(265, 143);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 30);
            this.btnCapNhat.TabIndex = 79;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbMaPhieu
            // 
            this.cbMaPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaPhieu.DataSource = this.pHIEUNHAPVATTUPHUTUNGBindingSource;
            this.cbMaPhieu.DisplayMember = "SoPhieuNhap";
            this.cbMaPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhieu.FormattingEnabled = true;
            this.cbMaPhieu.Location = new System.Drawing.Point(103, 10);
            this.cbMaPhieu.Name = "cbMaPhieu";
            this.cbMaPhieu.Size = new System.Drawing.Size(92, 26);
            this.cbMaPhieu.TabIndex = 78;
            this.cbMaPhieu.ValueMember = "SoPhieuNhap";
            this.cbMaPhieu.SelectedIndexChanged += new System.EventHandler(this.cbMaPhieu_SelectedIndexChanged);
            // 
            // pHIEUNHAPVATTUPHUTUNGBindingSource
            // 
            this.pHIEUNHAPVATTUPHUTUNGBindingSource.DataMember = "PHIEUNHAPVATTUPHUTUNG";
            this.pHIEUNHAPVATTUPHUTUNGBindingSource.DataSource = this.qUAN_LY_GARADataSet;
            // 
            // qUAN_LY_GARADataSet
            // 
            this.qUAN_LY_GARADataSet.DataSetName = "QUAN_LY_GARADataSet";
            this.qUAN_LY_GARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhieuMoi
            // 
            this.PhieuMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhieuMoi.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuMoi.Appearance.Options.UseFont = true;
            this.PhieuMoi.Image = ((System.Drawing.Image)(resources.GetObject("PhieuMoi.Image")));
            this.PhieuMoi.Location = new System.Drawing.Point(201, 11);
            this.PhieuMoi.Name = "PhieuMoi";
            this.PhieuMoi.Size = new System.Drawing.Size(83, 25);
            this.PhieuMoi.TabIndex = 77;
            this.PhieuMoi.Text = "Phiếu Mới";
            this.PhieuMoi.Click += new System.EventHandler(this.PhieuMoi_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(299, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 18);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Mã VTPT:";
            // 
            // cbMaVTPT
            // 
            this.cbMaVTPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaVTPT.DataSource = this.vATTUPHUTUNGBindingSource;
            this.cbMaVTPT.DisplayMember = "MaVatTu";
            this.cbMaVTPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaVTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaVTPT.FormattingEnabled = true;
            this.cbMaVTPT.Location = new System.Drawing.Point(384, 10);
            this.cbMaVTPT.Name = "cbMaVTPT";
            this.cbMaVTPT.Size = new System.Drawing.Size(112, 26);
            this.cbMaVTPT.TabIndex = 74;
            this.cbMaVTPT.ValueMember = "MaVatTu";
            this.cbMaVTPT.SelectedIndexChanged += new System.EventHandler(this.cbMaVTPT_SelectedIndexChanged);
            this.cbMaVTPT.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // vATTUPHUTUNGBindingSource
            // 
            this.vATTUPHUTUNGBindingSource.DataMember = "VATTUPHUTUNG";
            this.vATTUPHUTUNGBindingSource.DataSource = this.qUAN_LY_GARADataSet;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(410, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 29);
            this.btnXoa.TabIndex = 73;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl8.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl8.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl8.Location = new System.Drawing.Point(23, 13);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 18);
            this.labelControl8.TabIndex = 72;
            this.labelControl8.Text = "Mã phiếu:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhTien.BackColor = System.Drawing.Color.Khaki;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Location = new System.Drawing.Point(602, 106);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(112, 24);
            this.txtThanhTien.TabIndex = 70;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(521, 109);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 18);
            this.labelControl6.TabIndex = 69;
            this.labelControl6.Text = "Thành tiền:";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhap.Location = new System.Drawing.Point(103, 104);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(139, 24);
            this.dateNgayNhap.TabIndex = 67;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl4.Location = new System.Drawing.Point(11, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 18);
            this.labelControl4.TabIndex = 66;
            this.labelControl4.Text = "Ngày nhập:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Enabled = false;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(113, 143);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(114, 29);
            this.btnThemMoi.TabIndex = 65;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(384, 60);
            this.txtSoLuong.MaxLength = 10;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(83, 24);
            this.txtSoLuong.TabIndex = 64;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(384, 106);
            this.txtDonGia.MaxLength = 18;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(110, 24);
            this.txtDonGia.TabIndex = 63;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // txtTenVTPT
            // 
            this.txtTenVTPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenVTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVTPT.Location = new System.Drawing.Point(103, 60);
            this.txtTenVTPT.Name = "txtTenVTPT";
            this.txtTenVTPT.ReadOnly = true;
            this.txtTenVTPT.Size = new System.Drawing.Size(139, 24);
            this.txtTenVTPT.TabIndex = 62;
            this.txtTenVTPT.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl3.Location = new System.Drawing.Point(312, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 18);
            this.labelControl3.TabIndex = 61;
            this.labelControl3.Text = "Đơn giá:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl2.Location = new System.Drawing.Point(305, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 18);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Số lượng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(14, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 18);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "Tên VTPT:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tableDSVTPT);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 179);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(726, 138);
            this.panelControl2.TabIndex = 1;
            // 
            // tableDSVTPT
            // 
            this.tableDSVTPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDSVTPT.BackgroundColor = System.Drawing.Color.White;
            this.tableDSVTPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDSVTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDSVTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.mavattuphutung,
            this.tenvattuphutung,
            this.ngaynhap,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.tableDSVTPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDSVTPT.Location = new System.Drawing.Point(2, 2);
            this.tableDSVTPT.Name = "tableDSVTPT";
            this.tableDSVTPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDSVTPT.Size = new System.Drawing.Size(722, 134);
            this.tableDSVTPT.TabIndex = 1;
            this.tableDSVTPT.Click += new System.EventHandler(this.tableDSVTPT_Click);
            this.tableDSVTPT.DoubleClick += new System.EventHandler(this.tableDSVTPT_DoubleClick);
            // 
            // maphieu
            // 
            this.maphieu.DataPropertyName = "SoPhieuNhap";
            this.maphieu.HeaderText = "Mã Phiếu ";
            this.maphieu.Name = "maphieu";
            this.maphieu.ReadOnly = true;
            // 
            // mavattuphutung
            // 
            this.mavattuphutung.DataPropertyName = "MaVatTu";
            this.mavattuphutung.HeaderText = "Mã VTPT";
            this.mavattuphutung.Name = "mavattuphutung";
            this.mavattuphutung.ReadOnly = true;
            // 
            // tenvattuphutung
            // 
            this.tenvattuphutung.DataPropertyName = "TenVatTu";
            this.tenvattuphutung.HeaderText = "Tên Vật Tư Phụ Tùng ";
            this.tenvattuphutung.Name = "tenvattuphutung";
            this.tenvattuphutung.ReadOnly = true;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "NgayNhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SoLuongNhap";
            this.soluong.HeaderText = "Số lượng ";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "DonGia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "TongTien";
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // vATTUPHUTUNGTableAdapter
            // 
            this.vATTUPHUTUNGTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUNHAPVATTUPHUTUNGTableAdapter
            // 
            this.pHIEUNHAPVATTUPHUTUNGTableAdapter.ClearBeforeFill = true;
            // 
            // FormQLVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 317);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLVatTu";
            this.Text = "FormQuanLyVatTu";
            this.Load += new System.EventHandler(this.FormQLVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPVATTUPHUTUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDSVTPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView tableDSVTPT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbMaVTPT;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenVTPT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QUAN_LY_GARADataSet qUAN_LY_GARADataSet;
        private System.Windows.Forms.BindingSource vATTUPHUTUNGBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.VATTUPHUTUNGTableAdapter vATTUPHUTUNGTableAdapter;
        private DevExpress.XtraEditors.SimpleButton PhieuMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavattuphutung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvattuphutung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.ComboBox cbMaPhieu;
        private System.Windows.Forms.BindingSource pHIEUNHAPVATTUPHUTUNGBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.PHIEUNHAPVATTUPHUTUNGTableAdapter pHIEUNHAPVATTUPHUTUNGTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
    }
}