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
    public partial class Frm_FATURALAR : Form
    {
        public Frm_FATURALAR()
        {
            InitializeComponent();
        }

        private void TxtYETKILI_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            TxtID.Text = "";
            TxtSIRANO.Text = "";
            TxtSERI.Text = "";
            MskTARIH.Text = "";
            MskSAAT.Text = "";
            TxtALICI.Text = "";
            TxtTESLIMEDEN.Text = "";
            TxtTESLIMALAN.Text = "";
            TxtVERGIDAIRE.Text = "";
        }
        private void Frm_FATURALAR_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            if (TxtFATURAID.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtSERI.Text);
                komut.Parameters.AddWithValue("@P2", TxtSIRANO.Text);
                komut.Parameters.AddWithValue("@P3", MskTARIH.Text);
                komut.Parameters.AddWithValue("@P4", MskSAAT.Text);
                komut.Parameters.AddWithValue("@P5", TxtVERGIDAIRE.Text);
                komut.Parameters.AddWithValue("@P6", TxtALICI.Text);
                komut.Parameters.AddWithValue("@P7", TxtTESLIMEDEN.Text);
                komut.Parameters.AddWithValue("@P8", TxtTESLIMALAN.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura bilgisi sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                Temizle();
            }
            if (TxtFATURAID.Text !="")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFIYAT.Text);
                miktar = Convert.ToDouble(TxtADET.Text);
                tutar = miktar * fiyat;
                TxtTUTAR.Text = tutar.ToString(); 
                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@P1", TxtURUNADI.Text);
                komut2.Parameters.AddWithValue("@P2", TxtADET.Text);
                komut2.Parameters.AddWithValue("@P3", decimal.Parse(TxtFIYAT.Text));
                komut2.Parameters.AddWithValue("@P4", decimal.Parse(TxtTUTAR.Text));
                komut2.Parameters.AddWithValue("@P5", TxtFATURAID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert intıo TBL_FIRMAHAREKET (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) " +
                    "values (@p1,@p2,@p3,@p4,@p5.@p6,@p7,@p8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p1", TxtURUNID.Text);
                komut3.Parameters.AddWithValue("@p2", TxtADET.Text);
                komut3.Parameters.AddWithValue("@p3", TxtPersonel.Text);
                komut3.Parameters.AddWithValue("@p4", TxtFirma.Text);
                komut3.Parameters.AddWithValue("@p5", decimal.Parse(TxtFIYAT.Text));
                komut3.Parameters.AddWithValue("@p6", decimal.Parse(TxtTUTAR.Text));
                komut3.Parameters.AddWithValue("@p7", TxtFATURAID.Text);
                komut3.Parameters.AddWithValue("@p8", MskTARIH.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya ait ürün kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                Temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           
                TxtID.Text = dr["FATURABILGIID"].ToString();
                TxtSIRANO.Text = dr["SIRANO"].ToString();
                TxtSERI.Text = dr["SERI"].ToString();
                MskTARIH.Text = dr["TARIH"].ToString();
                MskSAAT.Text = dr["SAAT"].ToString();
                TxtALICI.Text = dr["ALICI"].ToString();
                TxtTESLIMEDEN.Text = dr["TESLIMEDEN"].ToString();
                TxtTESLIMALAN.Text = dr["TESLIMALAN"].ToString();
                TxtVERGIDAIRE.Text = dr["VERGIDAIRE"].ToString();
            
        }
        private void BtnTEMIZLE_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSIL_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Fatura silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();
        }

        private void BtnTEMIZLE_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGUNCELLE_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 where FATURABILGIID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtSERI.Text);
            komut.Parameters.AddWithValue("@P2", TxtSIRANO.Text);
            komut.Parameters.AddWithValue("@P3", MskTARIH.Text);
            komut.Parameters.AddWithValue("@P4", MskSAAT.Text);
            komut.Parameters.AddWithValue("@P5", TxtVERGIDAIRE.Text);
            komut.Parameters.AddWithValue("@P6", TxtALICI.Text);
            komut.Parameters.AddWithValue("@P7", TxtTESLIMEDEN.Text);
            komut.Parameters.AddWithValue("@P8", TxtTESLIMALAN.Text);
            komut.Parameters.AddWithValue("@P9", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura bilgisi güncellendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_FaturaUrunDetay fr = new Frm_FaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //grid viewde seçmiş olduğun satırın verisini al ama satırın bulunduğu alan                         
            if (dr !=null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select URUNADI,SATISFIYAT from TBL_URUNLER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtURUNID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtURUNADI.Text = "";
                TxtFIYAT.Text = "";
                TxtURUNADI.Text = dr[0].ToString();
                TxtFIYAT.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
