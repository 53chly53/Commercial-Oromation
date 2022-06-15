
namespace Ticari_Otomasyon
{
    partial class Frm_MAIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MAIL));
            this.TxtMailAdres = new DevExpress.XtraEditors.TextEdit();
            this.TxtKonu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMesaj = new System.Windows.Forms.RichTextBox();
            this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MailAdresi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMailAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMailAdres
            // 
            this.TxtMailAdres.Location = new System.Drawing.Point(150, 210);
            this.TxtMailAdres.Name = "TxtMailAdres";
            this.TxtMailAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtMailAdres.Properties.Appearance.Options.UseFont = true;
            this.TxtMailAdres.Size = new System.Drawing.Size(216, 26);
            this.TxtMailAdres.TabIndex = 1;
            // 
            // TxtKonu
            // 
            this.TxtKonu.Location = new System.Drawing.Point(150, 242);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtKonu.Properties.Appearance.Options.UseFont = true;
            this.TxtKonu.Size = new System.Drawing.Size(216, 26);
            this.TxtKonu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(94, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konu:";
            // 
            // TxtMesaj
            // 
            this.TxtMesaj.Location = new System.Drawing.Point(150, 273);
            this.TxtMesaj.Name = "TxtMesaj";
            this.TxtMesaj.Size = new System.Drawing.Size(216, 180);
            this.TxtMesaj.TabIndex = 4;
            this.TxtMesaj.Text = "";
            // 
            // BtnGonder
            // 
            this.BtnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnGonder.Appearance.Options.UseFont = true;
            this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGonder.ImageOptions.Image")));
            this.BtnGonder.Location = new System.Drawing.Point(187, 459);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(131, 23);
            this.BtnGonder.TabIndex = 5;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 185);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mail Gönderme Paneli";
            // 
            // MailAdresi
            // 
            this.MailAdresi.AutoSize = true;
            this.MailAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MailAdresi.Location = new System.Drawing.Point(54, 213);
            this.MailAdresi.Name = "MailAdresi";
            this.MailAdresi.Size = new System.Drawing.Size(90, 20);
            this.MailAdresi.TabIndex = 7;
            this.MailAdresi.Text = "Mail Adresi:";
            this.MailAdresi.Click += new System.EventHandler(this.MailAdresi_Click);
            // 
            // Frm_MAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(430, 579);
            this.Controls.Add(this.MailAdresi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.TxtMesaj);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMailAdres);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MAIL";
            this.Text = "FrmMAIL";
            this.Load += new System.EventHandler(this.FrmMAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMailAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TxtMailAdres;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TxtMesaj;
        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MailAdresi;
    }
}