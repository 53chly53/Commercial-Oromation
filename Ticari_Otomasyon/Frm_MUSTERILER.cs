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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();
         void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select sehir From iller",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtAD.Text = "";
            TxtMUSTERSOYAD.Text = "";
            MskTELEFON1.Text = "";
            MskTELEFON2.Text = "";
            MskTC.Text = "";
            TxtMAIL.Text = "";
            CmbIL.Text = "";
            CmbILCE.Text = "";
            RchADRES.Text = "";
            TxtVERGIDAIRE.Text = "";
        }
       
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
           
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtMUSTERSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTELEFON1.Text);
            komut.Parameters.AddWithValue("@p4", MskTELEFON2.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p7", CmbIL.Text);
            komut.Parameters.AddWithValue("@p8", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p9", TxtVERGIDAIRE.Text);
            komut.Parameters.AddWithValue("@p10", RchADRES.Text);
            komut.ExecuteNonQuery(); // dml komutlarını çalıştırır
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from ilceler where sehir=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",CmbIL.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            CmbILCE.Text = null;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAD.Text = dr["AD"].ToString();
                TxtMUSTERSOYAD.Text = dr["SOYAD"].ToString();
                MskTELEFON1.Text = dr["TELEFON"].ToString();
                MskTELEFON2.Text = dr["TELEFON2"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMAIL.Text = dr["MAIL"].ToString();
                CmbIL.Text = dr["IL"].ToString();
                CmbILCE.Text = dr["ILCE"].ToString();
                RchADRES.Text= dr["ADRES"].ToString();
                TxtVERGIDAIRE.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1",
               bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }
        private void BtnGUNCELLE_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_MUSTERILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9,VERGIDAIRE=@P10 WHERE ID=@P11 " , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtMUSTERSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTELEFON1.Text);
            komut.Parameters.AddWithValue("@p4", MskTELEFON2.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p7", CmbIL.Text);
            komut.Parameters.AddWithValue("@p8", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p9", TxtVERGIDAIRE.Text);    
            komut.Parameters.AddWithValue("@p10", RchADRES.Text);
            komut.Parameters.AddWithValue("@p11", TxtID.Text);
            komut.ExecuteNonQuery(); // dml komutlarını çalıştırır
            bgl.baglanti().Close();
            MessageBox.Show("Musteri bilgisi güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void CmbILCE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
 