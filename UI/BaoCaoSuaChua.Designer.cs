﻿namespace UI
{
    partial class BaoCaoSuaChua
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUAN_LY_GARADataSet = new UI.QUAN_LY_GARADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new UI.QUAN_LY_GARADataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUAN_LY_GARADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.QUAN_LY_GARADataSet;
            // 
            // QUAN_LY_GARADataSet
            // 
            this.QUAN_LY_GARADataSet.DataSetName = "QUAN_LY_GARADataSet";
            this.QUAN_LY_GARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 489);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoSuaChua
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(810, 489);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaoCaoSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoSuaChua";
            this.Load += new System.EventHandler(this.BaoCaoSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUAN_LY_GARADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private QUAN_LY_GARADataSet QUAN_LY_GARADataSet;
        private QUAN_LY_GARADataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}