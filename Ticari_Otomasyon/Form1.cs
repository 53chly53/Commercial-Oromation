using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ticari_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmMusteriler fr2;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2==null)
            {
                fr2 = new FrmMusteriler();
                fr2.MdiParent = this; //bu formun içerisinde mdi olarak açılmasını sağlar
                fr2.Show();
            }
        }
        Frm_URUNLER fr;
        private void BtnURUNLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new Frm_URUNLER();
                fr.MdiParent = this; //bu formun içerisinde mdi olarak açılmasını sağlar
                fr.Show();
            }
        }
        Frm_FIRMALAR fr3;
        private void BtnFIRMALAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new Frm_FIRMALAR();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        Frm_PERSONEL fr4;
        private void BtnPERSONELLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new Frm_PERSONEL();
                fr4.MdiParent = this; //bu formun içerisinde mdi olarak açılmasını sağlar
                fr4.Show();
            }
        }
        Frm_REHBER fr5;
        private void BtnREHBER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new Frm_REHBER();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        Frm_GIDERLER fr6;
        private void BtnGIDERLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 ==null)
            {
                fr6 = new Frm_GIDERLER();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        Frm_BANKALAR fr7;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null)
            {
                fr7 = new Frm_BANKALAR();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        Frm_FATURALAR fr8;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8==null)
            {
                fr8 = new Frm_FATURALAR();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        Frm_Notlar fr9;
        private void BtnNOTLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9==null)
            {
                fr9 = new Frm_Notlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        Frm_HAREKETLER fr10;
        private void BtnHAREKETLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10==null)
            {
                fr10 = new Frm_HAREKETLER();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        Frm_Raporlar fr11;
        private void BtnRAPORLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11==null)
            {
                fr11 = new Frm_Raporlar();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        Frm_AnaSayfa fr15;
        private void BtnANASAYFA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15==null)
            {
                fr15 = new Frm_AnaSayfa();
                fr15.MdiParent=this;
                fr15.Show();
            }
        }
        Frm_Stoklar fr12;
        private void BtnSTOKLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null)
            {
                fr12 = new Frm_Stoklar();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
        Frm_Ayarlar fr13;
        private void BtnAYARLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null)
            {
                fr13 = new Frm_Ayarlar();
                fr13.Show();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public string kullanici;
        FrmKASA fr14;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null)
            {
                fr14 = new FrmKASA();
                fr14.ad = kullanici;
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
    }
}
