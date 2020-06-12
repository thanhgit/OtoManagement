namespace UI
{
    partial class FormTiepNhanXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiepNhanXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtToiDa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDaNhan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenChuXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbHieuXe = new System.Windows.Forms.ComboBox();
            this.hIEUXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARADataSet = new UI.QUAN_LY_GARADataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBienSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.tableTiepNhanXe = new System.Windows.Forms.DataGridView();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIEUXETableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.HIEUXETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTiepNhanXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnCapNhat);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnThemMoi);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtDienThoai);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.txtTenChuXe);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.cbHieuXe);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtBienSo);
            this.panelControl1.Controls.Add(this.dateNgayTiepNhan);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(807, 188);
            this.panelControl1.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(524, 142);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 30);
            this.btnCapNhat.TabIndex = 52;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtToiDa);
            this.panelControl2.Controls.Add(this.txtDaNhan);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Location = new System.Drawing.Point(612, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(161, 91);
            this.panelControl2.TabIndex = 41;
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
            this.labelControl9.Location = new System.Drawing.Point(14, 16);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 18);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "Đã nhận:";
            // 
            // txtToiDa
            // 
            this.txtToiDa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtToiDa.Border.Class = "TextBoxBorder";
            this.txtToiDa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToiDa.Location = new System.Drawing.Point(94, 55);
            this.txtToiDa.MaxLength = 4;
            this.txtToiDa.Name = "txtToiDa";
            this.txtToiDa.PreventEnterBeep = true;
            this.txtToiDa.Size = new System.Drawing.Size(39, 24);
            this.txtToiDa.TabIndex = 40;
            this.txtToiDa.Tag = "1";
            this.txtToiDa.Leave += new System.EventHandler(this.txtToiDa_Leave);
            // 
            // txtDaNhan
            // 
            this.txtDaNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtDaNhan.Border.Class = "TextBoxBorder";
            this.txtDaNhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaNhan.Location = new System.Drawing.Point(94, 10);
            this.txtDaNhan.Name = "txtDaNhan";
            this.txtDaNhan.PreventEnterBeep = true;
            this.txtDaNhan.ReadOnly = true;
            this.txtDaNhan.Size = new System.Drawing.Size(39, 24);
            this.txtDaNhan.TabIndex = 37;
            this.txtDaNhan.Tag = "1";
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
            this.labelControl8.Location = new System.Drawing.Point(27, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 18);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "Tối đa:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(643, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 29);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThemMoi.Enabled = false;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(383, 142);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(110, 29);
            this.btnThemMoi.TabIndex = 35;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            this.labelControl7.Location = new System.Drawing.Point(42, 142);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 18);
            this.labelControl7.TabIndex = 34;
            this.labelControl7.Text = "Ngày tiếp nhận:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(468, 97);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(222, 24);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.Tag = "1";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
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
            this.labelControl6.Location = new System.Drawing.Point(402, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 18);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Email:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(468, 57);
            this.txtDienThoai.MaxLength = 12;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.PreventEnterBeep = true;
            this.txtDienThoai.Size = new System.Drawing.Size(138, 24);
            this.txtDienThoai.TabIndex = 31;
            this.txtDienThoai.Tag = "1";
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
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
            this.labelControl5.Location = new System.Drawing.Point(371, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 18);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(174, 101);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PreventEnterBeep = true;
            this.txtDiaChi.Size = new System.Drawing.Size(138, 24);
            this.txtDiaChi.TabIndex = 29;
            this.txtDiaChi.Tag = "1";
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
            // 
            // txtTenChuXe
            // 
            this.txtTenChuXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtTenChuXe.Border.Class = "TextBoxBorder";
            this.txtTenChuXe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuXe.Location = new System.Drawing.Point(174, 57);
            this.txtTenChuXe.MaxLength = 100;
            this.txtTenChuXe.Name = "txtTenChuXe";
            this.txtTenChuXe.PreventEnterBeep = true;
            this.txtTenChuXe.Size = new System.Drawing.Size(138, 24);
            this.txtTenChuXe.TabIndex = 28;
            this.txtTenChuXe.Tag = "1";
            this.txtTenChuXe.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
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
            this.labelControl3.Location = new System.Drawing.Point(99, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 18);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Địa chỉ:";
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
            this.labelControl2.Location = new System.Drawing.Point(386, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 18);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Hiệu xe:";
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
            this.labelControl4.Location = new System.Drawing.Point(66, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 18);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Tên chủ xe:";
            // 
            // cbHieuXe
            // 
            this.cbHieuXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbHieuXe.DataSource = this.hIEUXEBindingSource;
            this.cbHieuXe.DisplayMember = "HieuXe";
            this.cbHieuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHieuXe.FormattingEnabled = true;
            this.cbHieuXe.Location = new System.Drawing.Point(468, 12);
            this.cbHieuXe.Name = "cbHieuXe";
            this.cbHieuXe.Size = new System.Drawing.Size(138, 26);
            this.cbHieuXe.TabIndex = 24;
            this.cbHieuXe.ValueMember = "HieuXe";
            // 
            // hIEUXEBindingSource
            // 
            this.hIEUXEBindingSource.DataMember = "HIEUXE";
            this.hIEUXEBindingSource.DataSource = this.qUAN_LY_GARADataSet;
            // 
            // qUAN_LY_GARADataSet
            // 
            this.qUAN_LY_GARADataSet.DataSetName = "QUAN_LY_GARADataSet";
            this.qUAN_LY_GARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.labelControl1.Location = new System.Drawing.Point(94, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 18);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Biển số:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtBienSo.Border.Class = "TextBoxBorder";
            this.txtBienSo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBienSo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(174, 12);
            this.txtBienSo.MaxLength = 15;
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.PreventEnterBeep = true;
            this.txtBienSo.Size = new System.Drawing.Size(138, 24);
            this.txtBienSo.TabIndex = 21;
            this.txtBienSo.Tag = "1";
            this.txtBienSo.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
            // 
            // dateNgayTiepNhan
            // 
            this.dateNgayTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateNgayTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTiepNhan.Location = new System.Drawing.Point(174, 142);
            this.dateNgayTiepNhan.Name = "dateNgayTiepNhan";
            this.dateNgayTiepNhan.Size = new System.Drawing.Size(138, 24);
            this.dateNgayTiepNhan.TabIndex = 20;
            // 
            // tableTiepNhanXe
            // 
            this.tableTiepNhanXe.AllowUserToOrderColumns = true;
            this.tableTiepNhanXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableTiepNhanXe.BackgroundColor = System.Drawing.Color.White;
            this.tableTiepNhanXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTiepNhanXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableTiepNhanXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTiepNhanXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.HieuXe,
            this.TenChuXe,
            this.DiaChi,
            this.DienThoai,
            this.Email,
            this.NgayTiepNhan,
            this.TienNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableTiepNhanXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableTiepNhanXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableTiepNhanXe.Location = new System.Drawing.Point(0, 178);
            this.tableTiepNhanXe.Name = "tableTiepNhanXe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTiepNhanXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableTiepNhanXe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tableTiepNhanXe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tableTiepNhanXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableTiepNhanXe.Size = new System.Drawing.Size(807, 135);
            this.tableTiepNhanXe.TabIndex = 4;
            this.tableTiepNhanXe.Click += new System.EventHandler(this.tableTiepNhanXe_Click);
            this.tableTiepNhanXe.DoubleClick += new System.EventHandler(this.tableTiepNhanXe_DoubleClick);
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BienSo.DefaultCellStyle = dataGridViewCellStyle2;
            this.BienSo.HeaderText = "Biển Số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // HieuXe
            // 
            this.HieuXe.DataPropertyName = "HieuXe";
            this.HieuXe.HeaderText = "Hiệu Xe";
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // TenChuXe
            // 
            this.TenChuXe.DataPropertyName = "TenChuXe";
            this.TenChuXe.HeaderText = "Tên Chủ Xe";
            this.TenChuXe.Name = "TenChuXe";
            this.TenChuXe.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Số ĐT";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NgayTiepNhan
            // 
            this.NgayTiepNhan.DataPropertyName = "NgayTiepNhan";
            this.NgayTiepNhan.HeaderText = "Ngày Tiếp Nhận";
            this.NgayTiepNhan.Name = "NgayTiepNhan";
            this.NgayTiepNhan.ReadOnly = true;
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "TienNo";
            this.TienNo.HeaderText = "Tiền Nợ";
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // hIEUXETableAdapter
            // 
            this.hIEUXETableAdapter.ClearBeforeFill = true;
            // 
            // FormTiepNhanXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 313);
            this.Controls.Add(this.tableTiepNhanXe);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTiepNhanXe";
            this.Text = "FormPhieuSuaChua";
            this.Load += new System.EventHandler(this.FormTiepNhanXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTiepNhanXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenChuXe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbHieuXe;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBienSo;
        private System.Windows.Forms.DateTimePicker dateNgayTiepNhan;
        private System.Windows.Forms.DataGridView tableTiepNhanXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private QUAN_LY_GARADataSet qUAN_LY_GARADataSet;
        private System.Windows.Forms.BindingSource hIEUXEBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.HIEUXETableAdapter hIEUXETableAdapter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtToiDa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDaNhan;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
    }
}