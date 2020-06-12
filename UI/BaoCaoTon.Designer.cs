namespace UI
{
    partial class BaoCaoTon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QUAN_LY_GARADataSet = new UI.QUAN_LY_GARADataSet();
            this.sp_BaoCaoTonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BaoCaoTonTableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.sp_BaoCaoTonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QUAN_LY_GARADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoTonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_BaoCaoTonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(953, 548);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // QUAN_LY_GARADataSet
            // 
            this.QUAN_LY_GARADataSet.DataSetName = "QUAN_LY_GARADataSet";
            this.QUAN_LY_GARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_BaoCaoTonBindingSource
            // 
            this.sp_BaoCaoTonBindingSource.DataMember = "sp_BaoCaoTon";
            this.sp_BaoCaoTonBindingSource.DataSource = this.QUAN_LY_GARADataSet;
            // 
            // sp_BaoCaoTonTableAdapter
            // 
            this.sp_BaoCaoTonTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 548);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaoCaoTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoTon";
            this.Load += new System.EventHandler(this.BaoCaoTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUAN_LY_GARADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoTonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_BaoCaoTonBindingSource;
        private QUAN_LY_GARADataSet QUAN_LY_GARADataSet;
        private QUAN_LY_GARADataSetTableAdapters.sp_BaoCaoTonTableAdapter sp_BaoCaoTonTableAdapter;
    }
}