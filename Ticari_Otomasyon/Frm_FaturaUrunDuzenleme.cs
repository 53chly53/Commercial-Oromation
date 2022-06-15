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
    public partial class Frm_FaturaUrunDuzenleme : Form
    {
        public Frm_FaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
       
      
        public string urunid;
        
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            TxtAD.Text = urunid;
            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FATURABILGIID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                TxtID.Text=dr[0].ToString();
                TxtAD.Text = dr[1].ToString();
                TxtMIKTAR.Text = dr[2].ToString();
                TxtFIYAT.Text = dr[3].ToString();

                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFIYAT.Text);
                miktar = Convert.ToDouble(TxtMIKTAR.Text);
                tutar = miktar * fiyat;
                TxtTUTAR.Text = tutar.ToString();

                TxtTUTAR.Text = dr[4].ToString();
                bgl.baglanti().Close();
            }
        }
        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 where FATURABILGIID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtMIKTAR.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtFIYAT.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtTUTAR.Text));
            komut.Parameters.AddWithValue("@p5", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question); 
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
