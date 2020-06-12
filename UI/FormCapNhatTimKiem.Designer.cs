namespace UI
{
    partial class FormCapNhatTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatTimKiem));
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
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
            this.txtTienNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.hIEUXETableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.HIEUXETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(302, 208);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 41);
            this.btnCapNhat.TabIndex = 69;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.labelControl7.Location = new System.Drawing.Point(33, 162);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 18);
            this.labelControl7.TabIndex = 66;
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
            this.txtEmail.Location = new System.Drawing.Point(459, 117);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(222, 24);
            this.txtEmail.TabIndex = 65;
            this.txtEmail.Tag = "1";
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
            this.labelControl6.Location = new System.Drawing.Point(393, 119);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 18);
            this.labelControl6.TabIndex = 64;
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
            this.txtDienThoai.Location = new System.Drawing.Point(459, 77);
            this.txtDienThoai.MaxLength = 12;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.PreventEnterBeep = true;
            this.txtDienThoai.Size = new System.Drawing.Size(138, 24);
            this.txtDienThoai.TabIndex = 63;
            this.txtDienThoai.Tag = "1";
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
            this.labelControl5.Location = new System.Drawing.Point(362, 77);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 18);
            this.labelControl5.TabIndex = 62;
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
            this.txtDiaChi.Location = new System.Drawing.Point(165, 121);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PreventEnterBeep = true;
            this.txtDiaChi.Size = new System.Drawing.Size(138, 24);
            this.txtDiaChi.TabIndex = 61;
            this.txtDiaChi.Tag = "1";
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
            this.txtTenChuXe.Location = new System.Drawing.Point(165, 77);
            this.txtTenChuXe.MaxLength = 100;
            this.txtTenChuXe.Name = "txtTenChuXe";
            this.txtTenChuXe.PreventEnterBeep = true;
            this.txtTenChuXe.Size = new System.Drawing.Size(138, 24);
            this.txtTenChuXe.TabIndex = 60;
            this.txtTenChuXe.Tag = "1";
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
            this.labelControl3.Location = new System.Drawing.Point(90, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 18);
            this.labelControl3.TabIndex = 59;
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
            this.labelControl2.Location = new System.Drawing.Point(377, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 18);
            this.labelControl2.TabIndex = 58;
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
            this.labelControl4.Location = new System.Drawing.Point(57, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 18);
            this.labelControl4.TabIndex = 57;
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
            this.cbHieuXe.Location = new System.Drawing.Point(459, 32);
            this.cbHieuXe.Name = "cbHieuXe";
            this.cbHieuXe.Size = new System.Drawing.Size(138, 26);
            this.cbHieuXe.TabIndex = 56;
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
            this.labelControl1.Location = new System.Drawing.Point(85, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 18);
            this.labelControl1.TabIndex = 55;
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
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(165, 32);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.PreventEnterBeep = true;
            this.txtBienSo.ReadOnly = true;
            this.txtBienSo.Size = new System.Drawing.Size(138, 24);
            this.txtBienSo.TabIndex = 54;
            this.txtBienSo.Tag = "1";
            // 
            // dateNgayTiepNhan
            // 
            this.dateNgayTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateNgayTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTiepNhan.Location = new System.Drawing.Point(165, 162);
            this.dateNgayTiepNhan.Name = "dateNgayTiepNhan";
            this.dateNgayTiepNhan.Size = new System.Drawing.Size(138, 24);
            this.dateNgayTiepNhan.TabIndex = 53;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtTienNo.Border.Class = "TextBoxBorder";
            this.txtTienNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNo.Location = new System.Drawing.Point(459, 160);
            this.txtTienNo.MaxLength = 18;
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.PreventEnterBeep = true;
            this.txtTienNo.Size = new System.Drawing.Size(138, 24);
            this.txtTienNo.TabIndex = 71;
            this.txtTienNo.Tag = "1";
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
            this.labelControl8.Location = new System.Drawing.Point(377, 162);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 18);
            this.labelControl8.TabIndex = 70;
            this.labelControl8.Text = "Tiền nợ:";
            // 
            // hIEUXETableAdapter
            // 
            this.hIEUXETableAdapter.ClearBeforeFill = true;
            // 
            // FormCapNhatTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 261);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenChuXe);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbHieuXe);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.dateNgayTiepNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCapNhatTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.FormCapNhatTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
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
        private DevComponents.DotNetBar.Controls.TextBoxX txtTienNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private QUAN_LY_GARADataSet qUAN_LY_GARADataSet;
        private System.Windows.Forms.BindingSource hIEUXEBindingSource;
        private QUAN_LY_GARADataSetTableAdapters.HIEUXETableAdapter hIEUXETableAdapter;
    }
}