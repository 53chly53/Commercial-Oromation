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
using System.Xml;
namespace Ticari_Otomasyon
    
{
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUNADI,Sum(ADET) as 'Adet' from TBL_URUNLER " +
                "group by URUNADI having SUM(ADET) <=20 order by SUM(adet)", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void arjanda()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select top 8 TARIH,SAAT,BASLIK from TBL_NOTLAR order by ID desc ",bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }
        void FirmaHareketler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareketler2",bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        void Fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,Telefon1 from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }
        void haberler()
        {
            XmlTextReader xmltexoku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while(xmltexoku.Read())
                if (xmltexoku.Name == "title")
                {
                 listBox1.Items.Add(xmltexoku.ReadString());
                }    
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");

            stoklar();
            arjanda();
            FirmaHareketler();
            Fihrist();

            haberler();
            

        }
    }
}
