namespace Ticari_Otomasyon
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullanıcıAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtSıfre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGırısYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanıcıAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıfre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtKullanıcıAd
            // 
            this.TxtKullanıcıAd.EditValue = "";
            this.TxtKullanıcıAd.Location = new System.Drawing.Point(207, 127);
            this.TxtKullanıcıAd.Name = "TxtKullanıcıAd";
            this.TxtKullanıcıAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtKullanıcıAd.Properties.Appearance.Options.UseFont = true;
            this.TxtKullanıcıAd.Size = new System.Drawing.Size(100, 26);
            this.TxtKullanıcıAd.TabIndex = 1;
            this.TxtKullanıcıAd.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(207, 159);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtSıfre.Properties.Appearance.Options.UseFont = true;
            this.TxtSıfre.Properties.UseSystemPasswordChar = true;
            this.TxtSıfre.Size = new System.Drawing.Size(100, 26);
            this.TxtSıfre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // BtnGırısYap
            // 
            this.BtnGırısYap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGırısYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnGırısYap.Location = new System.Drawing.Point(207, 191);
            this.BtnGırısYap.Name = "BtnGırısYap";
            this.BtnGırısYap.Size = new System.Drawing.Size(100, 23);
            this.BtnGırısYap.TabIndex = 4;
            this.BtnGırısYap.Text = "Giriş Yap";
            this.BtnGırısYap.UseVisualStyleBackColor = false;
            this.BtnGırısYap.Click += new System.EventHandler(this.BtnGırısYap_Click);
            this.BtnGırısYap.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.BtnGırısYap.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.BtnGırısYap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(155, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "UDEMY TİCARİ OTOMASYON-2022";
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGırısYap);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullanıcıAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanıcıAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıfre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtKullanıcıAd;
        private DevExpress.XtraEditors.TextEdit TxtSıfre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGırısYap;
        private System.Windows.Forms.Label label3;
    }
}