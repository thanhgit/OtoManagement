namespace UI
{
    partial class FormQLHieuXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHieuXe));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvDanhSachHieuXe = new System.Windows.Forms.DataGridView();
            this.TableHieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuocSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtNuocSanXuat = new System.Windows.Forms.TextBox();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHieuXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvDanhSachHieuXe);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(333, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(401, 306);
            this.panelControl1.TabIndex = 0;
            // 
            // dgvDanhSachHieuXe
            // 
            this.dgvDanhSachHieuXe.AllowDrop = true;
            this.dgvDanhSachHieuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHieuXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachHieuXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHieuXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableHieuXe,
            this.NuocSanXuat});
            this.dgvDanhSachHieuXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHieuXe.Location = new System.Drawing.Point(2, 2);
            this.dgvDanhSachHieuXe.Name = "dgvDanhSachHieuXe";
            this.dgvDanhSachHieuXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHieuXe.Size = new System.Drawing.Size(397, 302);
            this.dgvDanhSachHieuXe.TabIndex = 1;
            this.dgvDanhSachHieuXe.Click += new System.EventHandler(this.tableDSTienCong_Click);
            this.dgvDanhSachHieuXe.DoubleClick += new System.EventHandler(this.tableDSTienCong_DoubleClick);
            // 
            // TableHieuXe
            // 
            this.TableHieuXe.DataPropertyName = "HieuXe";
            this.TableHieuXe.HeaderText = "Hiệu xe";
            this.TableHieuXe.Name = "TableHieuXe";
            this.TableHieuXe.ReadOnly = true;
            // 
            // NuocSanXuat
            // 
            this.NuocSanXuat.DataPropertyName = "NuocSanXuat";
            this.NuocSanXuat.HeaderText = "Nước sản xuất";
            this.NuocSanXuat.Name = "NuocSanXuat";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThemMoi);
            this.panelControl2.Controls.Add(this.btnCapNhat);
            this.panelControl2.Controls.Add(this.txtNuocSanXuat);
            this.panelControl2.Controls.Add(this.txtHieuXe);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(327, 306);
            this.panelControl2.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMoi.Enabled = false;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(52, 183);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(91, 30);
            this.btnThemMoi.TabIndex = 52;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(170, 183);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 30);
            this.btnCapNhat.TabIndex = 51;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNuocSanXuat
            // 
            this.txtNuocSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNuocSanXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuocSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuocSanXuat.Location = new System.Drawing.Point(154, 129);
            this.txtNuocSanXuat.MaxLength = 50;
            this.txtNuocSanXuat.Name = "txtNuocSanXuat";
            this.txtNuocSanXuat.Size = new System.Drawing.Size(122, 24);
            this.txtNuocSanXuat.TabIndex = 50;
            this.txtNuocSanXuat.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHieuXe.Location = new System.Drawing.Point(154, 69);
            this.txtHieuXe.MaxLength = 30;
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(122, 24);
            this.txtHieuXe.TabIndex = 49;
            this.txtHieuXe.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(42, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 18);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Nước sản xuất:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(89, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 18);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Hiệu xe:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(52, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 29);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormQLHieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 306);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLHieuXe";
            this.Text = "FormQLHieuXe";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHieuXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvDanhSachHieuXe;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox txtNuocSanXuat;
        private System.Windows.Forms.TextBox txtHieuXe;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableHieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuocSanXuat;
    }
}