namespace Ticari_Otomasyon
{
    partial class Frm_Notlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtHITAP = new DevExpress.XtraEditors.TextEdit();
            this.MskSAAT = new System.Windows.Forms.MaskedTextBox();
            this.MskTARIH = new System.Windows.Forms.MaskedTextBox();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.TxtBASLIK = new DevExpress.XtraEditors.TextEdit();
            this.BtnGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.RchDETAY = new System.Windows.Forms.RichTextBox();
            this.BtnSIL = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOLUSTURAN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelcontrol1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHITAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBASLIK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOLUSTURAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtHITAP);
            this.groupControl1.Controls.Add(this.MskSAAT);
            this.groupControl1.Controls.Add(this.MskTARIH);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.TxtBASLIK);
            this.groupControl1.Controls.Add(this.BtnGUNCELLE);
            this.groupControl1.Controls.Add(this.RchDETAY);
            this.groupControl1.Controls.Add(this.BtnSIL);
            this.groupControl1.Controls.Add(this.BtnKAYDET);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtOLUSTURAN);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelcontrol1);
            this.groupControl1.Location = new System.Drawing.Point(757, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(234, 585);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // TxtHITAP
            // 
            this.TxtHITAP.Location = new System.Drawing.Point(93, 184);
            this.TxtHITAP.Name = "TxtHITAP";
            this.TxtHITAP.Size = new System.Drawing.Size(126, 20);
            this.TxtHITAP.TabIndex = 42;
            // 
            // MskSAAT
            // 
            this.MskSAAT.Location = new System.Drawing.Point(93, 100);
            this.MskSAAT.Mask = "00:00";
            this.MskSAAT.Name = "MskSAAT";
            this.MskSAAT.Size = new System.Drawing.Size(126, 21);
            this.MskSAAT.TabIndex = 41;
            this.MskSAAT.ValidatingType = typeof(System.DateTime);
            // 
            // MskTARIH
            // 
            this.MskTARIH.Location = new System.Drawing.Point(93, 74);
            this.MskTARIH.Mask = "00/00/0000";
            this.MskTARIH.Name = "MskTARIH";
            this.MskTARIH.Size = new System.Drawing.Size(126, 21);
            this.MskTARIH.TabIndex = 40;
            this.MskTARIH.ValidatingType = typeof(System.DateTime);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(93, 372);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(126, 29);
            this.BtnTemizle.TabIndex = 39;
            this.BtnTemizle.Text = "TEMIZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(93, 48);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(126, 20);
            this.TxtID.TabIndex = 32;
            // 
            // TxtBASLIK
            // 
            this.TxtBASLIK.Location = new System.Drawing.Point(93, 127);
            this.TxtBASLIK.Name = "TxtBASLIK";
            this.TxtBASLIK.Size = new System.Drawing.Size(126, 20);
            this.TxtBASLIK.TabIndex = 31;
            // 
            // BtnGUNCELLE
            // 
            this.BtnGUNCELLE.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGUNCELLE.Appearance.Options.UseFont = true;
            this.BtnGUNCELLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGUNCELLE.ImageOptions.Image")));
            this.BtnGUNCELLE.Location = new System.Drawing.Point(93, 337);
            this.BtnGUNCELLE.Name = "BtnGUNCELLE";
            this.BtnGUNCELLE.Size = new System.Drawing.Size(126, 29);
            this.BtnGUNCELLE.TabIndex = 30;
            this.BtnGUNCELLE.Text = "GUNCELLE";
            this.BtnGUNCELLE.Click += new System.EventHandler(this.BtnGUNCELLE_Click);
            // 
            // RchDETAY
            // 
            this.RchDETAY.Location = new System.Drawing.Point(93, 214);
            this.RchDETAY.Name = "RchDETAY";
            this.RchDETAY.Size = new System.Drawing.Size(126, 36);
            this.RchDETAY.TabIndex = 19;
            this.RchDETAY.Text = "";
            // 
            // BtnSIL
            // 
            this.BtnSIL.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnSIL.Appearance.Options.UseFont = true;
            this.BtnSIL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSIL.ImageOptions.Image")));
            this.BtnSIL.Location = new System.Drawing.Point(93, 302);
            this.BtnSIL.Name = "BtnSIL";
            this.BtnSIL.Size = new System.Drawing.Size(126, 29);
            this.BtnSIL.TabIndex = 21;
            this.BtnSIL.Text = "SİL";
            this.BtnSIL.Click += new System.EventHandler(this.BtnSIL_Click);
            // 
            // BtnKAYDET
            // 
            this.BtnKAYDET.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnKAYDET.Appearance.Options.UseFont = true;
            this.BtnKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKAYDET.ImageOptions.Image")));
            this.BtnKAYDET.Location = new System.Drawing.Point(93, 267);
            this.BtnKAYDET.Name = "BtnKAYDET";
            this.BtnKAYDET.Size = new System.Drawing.Size(126, 29);
            this.BtnKAYDET.TabIndex = 20;
            this.BtnKAYDET.Text = "KAYDET";
            this.BtnKAYDET.Click += new System.EventHandler(this.BtnKAYDET_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(39, 217);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "DETAY:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(41, 187);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(34, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "HITAP:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "OLUSTURAN:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "BASLIK:";
            // 
            // TxtOLUSTURAN
            // 
            this.TxtOLUSTURAN.Location = new System.Drawing.Point(93, 154);
            this.TxtOLUSTURAN.Name = "TxtOLUSTURAN";
            this.TxtOLUSTURAN.Size = new System.Drawing.Size(126, 20);
            this.TxtOLUSTURAN.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "SAAT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "TARIH:";
            // 
            // labelcontrol1
            // 
            this.labelcontrol1.Location = new System.Drawing.Point(60, 51);
            this.labelcontrol1.Name = "labelcontrol1";
            this.labelcontrol1.Size = new System.Drawing.Size(15, 13);
            this.labelcontrol1.TabIndex = 0;
            this.labelcontrol1.Text = "ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(739, 585);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Frm_Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Notlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHITAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBASLIK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOLUSTURAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.TextEdit TxtBASLIK;
        private DevExpress.XtraEditors.SimpleButton BtnGUNCELLE;
        private System.Windows.Forms.RichTextBox RchDETAY;
        private DevExpress.XtraEditors.SimpleButton BtnSIL;
        private DevExpress.XtraEditors.SimpleButton BtnKAYDET;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtOLUSTURAN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelcontrol1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TxtHITAP;
        private System.Windows.Forms.MaskedTextBox MskSAAT;
        private System.Windows.Forms.MaskedTextBox MskTARIH;
    }
}