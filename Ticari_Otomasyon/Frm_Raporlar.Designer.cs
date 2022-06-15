namespace Ticari_Otomasyon
{
    partial class Frm_Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Raporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBL_MUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celalprojeDataSet = new Ticari_Otomasyon.celalprojeDataSet();
            this.TBL_FIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_GIDERLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_PERSONELLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.XtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBL_MUSTERILERTableAdapter = new Ticari_Otomasyon.celalprojeDataSetTableAdapters.TBL_MUSTERILERTableAdapter();
            this.TBL_FIRMALARTableAdapter = new Ticari_Otomasyon.celalprojeDataSetTableAdapters.TBL_FIRMALARTableAdapter();
            this.TBL_GIDERLERTableAdapter = new Ticari_Otomasyon.celalprojeDataSetTableAdapters.TBL_GIDERLERTableAdapter();
            this.TBL_PERSONELLERTableAdapter = new Ticari_Otomasyon.celalprojeDataSetTableAdapters.TBL_PERSONELLERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celalprojeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_PERSONELLERBindingSource)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).BeginInit();
            this.XtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBL_MUSTERILERBindingSource
            // 
            this.TBL_MUSTERILERBindingSource.DataMember = "TBL_MUSTERILER";
            this.TBL_MUSTERILERBindingSource.DataSource = this.celalprojeDataSet;
            // 
            // celalprojeDataSet
            // 
            this.celalprojeDataSet.DataSetName = "celalprojeDataSet";
            this.celalprojeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_FIRMALARBindingSource
            // 
            this.TBL_FIRMALARBindingSource.DataMember = "TBL_FIRMALAR";
            this.TBL_FIRMALARBindingSource.DataSource = this.celalprojeDataSet;
            // 
            // TBL_GIDERLERBindingSource
            // 
            this.TBL_GIDERLERBindingSource.DataMember = "TBL_GIDERLER";
            this.TBL_GIDERLERBindingSource.DataSource = this.celalprojeDataSet;
            // 
            // TBL_PERSONELLERBindingSource
            // 
            this.TBL_PERSONELLERBindingSource.DataMember = "TBL_PERSONELLER";
            this.TBL_PERSONELLERBindingSource.DataSource = this.celalprojeDataSet;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.reportViewer5);
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1368, 705);
            this.xtraTabPage5.Text = "Personel Raporları";
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBL_PERSONELLERBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.rdlc.Personel.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1368, 705);
            this.reportViewer5.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer4);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1368, 705);
            this.xtraTabPage4.Text = "Gider Raporları";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TBL_GIDERLERBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.rdlc.Giderler.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1368, 705);
            this.reportViewer4.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1368, 705);
            this.xtraTabPage3.Text = "Kasa Raporları";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(342, 161);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(396, 246);
            this.reportViewer3.TabIndex = 0;
            // 
            // XtraTabControl1
            // 
            this.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.XtraTabControl1.Name = "XtraTabControl1";
            this.XtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.XtraTabControl1.Size = new System.Drawing.Size(1370, 749);
            this.XtraTabControl1.TabIndex = 1;
            this.XtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1368, 705);
            this.xtraTabPage2.Text = "Firma Raporları";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TBL_FIRMALARBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.rdlc.firmalar.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1368, 705);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1368, 705);
            this.xtraTabPage1.Text = "Müşteri Raporları";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TBL_MUSTERILERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.rdlc.Musteri.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1368, 705);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBL_MUSTERILERTableAdapter
            // 
            this.TBL_MUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_FIRMALARTableAdapter
            // 
            this.TBL_FIRMALARTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_GIDERLERTableAdapter
            // 
            this.TBL_GIDERLERTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_PERSONELLERTableAdapter
            // 
            this.TBL_PERSONELLERTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.XtraTabControl1);
            this.Name = "Frm_Raporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celalprojeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_PERSONELLERBindingSource)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).EndInit();
            this.XtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl XtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.BindingSource TBL_MUSTERILERBindingSource;
        private celalprojeDataSet celalprojeDataSet;
        private celalprojeDataSetTableAdapters.TBL_MUSTERILERTableAdapter TBL_MUSTERILERTableAdapter;
        private System.Windows.Forms.BindingSource TBL_FIRMALARBindingSource;
        private celalprojeDataSetTableAdapters.TBL_FIRMALARTableAdapter TBL_FIRMALARTableAdapter;
        private System.Windows.Forms.BindingSource TBL_GIDERLERBindingSource;
        private celalprojeDataSetTableAdapters.TBL_GIDERLERTableAdapter TBL_GIDERLERTableAdapter;
        private System.Windows.Forms.BindingSource TBL_PERSONELLERBindingSource;
        private celalprojeDataSetTableAdapters.TBL_PERSONELLERTableAdapter TBL_PERSONELLERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
    }
}