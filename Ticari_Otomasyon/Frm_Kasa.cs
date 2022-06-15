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
using DevExpress.Charts;
namespace Ticari_Otomasyon

{
    public partial class FrmKASA : Form
    {
        public FrmKASA()
        {
            InitializeComponent();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void fırmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            grid1.DataSource = dt;
        }
        void musterıhareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            grid2.DataSource = dt;
        }
        
        void giderler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER order by Id asc", bgl.baglanti());
            da.Fill(dt);
            grid3.DataSource = dt;
        }
        public string ad;
        private void FrmKASA_Load(object sender, EventArgs e)
        {
            giderler();
            musterıhareket();
            fırmahareket();
            LblAktıfKullanıcı.Text = ad;
            

            //Toplam tutarı hesaplama
            SqlCommand komut1 = new SqlCommand("Select Sum(Tutar) From TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblYapılanÖdemeler.Text = dr1[0].ToString() + "₺";
            }
           
            //Son ayın Faturaları 
            SqlCommand komut2 = new SqlCommand("Select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA)from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblÖdemeler.Text = dr2[0].ToString() + "₺";
            }
            
            //son ayın personel maaşları
            SqlCommand komut3 = new SqlCommand("Select Maaslar From TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblPersonelMaasları.Text = dr3[0].ToString()+ "₺";
            }

            //Toplam Muşteri Sayısı
            SqlCommand komut4 = new SqlCommand("Select count(*) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMusterıSayısı.Text = dr4[0].ToString();
            }

            //Toplam Firma Sayısı
            SqlCommand komut5 = new SqlCommand("Select count(*) from TBL_FIRMALAR",bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblFırmaSayısı.Text = dr5[0].ToString();
            }

            //Toplam Firma Şehir Sayısı
            SqlCommand komut6 = new SqlCommand("Select count(Distinct(IL)) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblFırmaSehırSayısı.Text = dr6[0].ToString();
            }
            //count(Distinct(IL)) illeri tekrarsız olarak say

            //Toplam Musteri Şehir Sayısı
            SqlCommand komut7 = new SqlCommand("Select count(Distinct(IL)) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblMusteriSehirSayısı.Text = dr7[0].ToString();
            }

            //Toplam Personel Sayısı
            SqlCommand komut8 = new SqlCommand("Select count(*) from TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                LblPersonelSayısı.Text = dr8[0].ToString();
            }

            //Stok urun Sayısı
            SqlCommand komut9 = new SqlCommand("Select Sum(Adet) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                LblStokSayısı.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

            //1.chart controle Elektirik Faturası son 4 ay listeleme

            SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK From TBL_GIDERLER order by ID Desc", bgl.baglanti());
            SqlDataReader dr10 = komut10.ExecuteReader();
            while (dr10.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                //stoklardaki kod yukardaki koda için bak
            }

            //2.chart controle Elektirik Faturası son 4 ay listeleme

            SqlCommand komut11 = new SqlCommand("Select top 4 AY,Su From TBL_GIDERLER order by ID Desc", bgl.baglanti());
            SqlDataReader dr11 = komut11.ExecuteReader();
            while (dr11.Read())
            {
                chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                //stoklardaki kod yukardaki koda için bak
            }



            bgl.baglanti().Close();
        }
        int sayaç = 0;
        int sayaç2 = 0;
        private void LblAktıfKullanıcı_Click(object sender, EventArgs e)
        {

        }

        private void groupControl6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblYapılanÖdemeler_Click(object sender, EventArgs e)
        {

        }

       
        

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            sayaç++;
            //Elektirik
            if (sayaç > 0 && sayaç <= 5)
            {
                GC1.Text = "Elektirik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayaç > 5 && sayaç <= 10)
            {
                GC1.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("Select top 4 AY,SU from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //Dogalgaz
            if (sayaç > 10 && sayaç <= 15)
            {
                GC1.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("Select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //İnternet
            if (sayaç > 15 && sayaç <= 20)
            {
                GC1.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("Select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            //Ekstra
            if (sayaç > 20 && sayaç <= 25)
            {
                GC1.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut14 = new SqlCommand("Select top 4 AY,EKSTRA from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayaç == 26)
            {
                sayaç = 0;
            }
            bgl.baglanti().Close();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            sayaç2++;
            //Elektirik
            if (sayaç2 > 0 && sayaç2 <= 5)
            {
                GC2.Text = "Elektirik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayaç2 > 5 && sayaç2 <= 10)
            {
                GC2.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("Select top 4 AY,SU from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //Dogalgaz
            if (sayaç2 > 10 && sayaç2 <= 15)
            {
                GC2.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("Select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //İnternet
            if (sayaç2 > 15 && sayaç2 <= 20)
            {
                GC2.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("Select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            //Ekstra
            if (sayaç2 > 20 && sayaç2 <= 25)
            {
                GC2.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut14 = new SqlCommand("Select top 4 AY,EKSTRA from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayaç2 == 26)
            {
                sayaç2 = 0;
            }
            bgl.baglanti().Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}