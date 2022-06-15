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
    public partial class Frm_PERSONEL : Form
    {
        public Frm_PERSONEL()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
       void personelistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmPERSONEL_Load(object sender, EventArgs e)
        {
            personelistele();
            sehirlistesi();
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values  (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTELEFON1.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p6", CmbIL.Text);
            komut.Parameters.AddWithValue("@p7", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p8", RchADRES.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel bilgileri kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelistele();
            temizle();
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from ilceler where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            CmbILCE.Text = null;
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAD.Text = dr["AD"].ToString();
                TxtSOYAD.Text = dr["SOYAD"].ToString();
                MskTELEFON1.Text = dr["TELEFON"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMAIL.Text = dr["MAIL"].ToString();
                CmbIL.Text = dr["IL"].ToString();
                CmbILCE.Text = dr["ILCE"].ToString();
                RchADRES.Text = dr["ADRES"].ToString();
                TxtGorev.Text = dr["GOREV"].ToString();
            }
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtAD.Text = "";
            TxtSOYAD.Text = "";
            MskTELEFON1.Text = "";
            MskTC.Text = "";
            TxtMAIL.Text = "";
            CmbIL.Text = "";
            CmbILCE.Text = "";
            RchADRES.Text = "";
            TxtGorev.Text = "";
            TxtAD.Focus();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_PERSONELLER where ID=@p1",
             bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel listeden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            personelistele();
            temizle();
        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 WHERE ID=@P10 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTELEFON1.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p6", CmbIL.Text);
            komut.Parameters.AddWithValue("@p7", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p8", RchADRES.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p10", TxtID.Text);
            komut.ExecuteNonQuery(); // dml komutlarını çalıştırır
            bgl.baglanti().Close();
            MessageBox.Show("Personel bilgisi güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelistele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["ID"].ToString();
            TxtAD.Text = dr["AD"].ToString();
            TxtSOYAD.Text = dr["SOYAD"].ToString();
            MskTELEFON1.Text = dr["TELEFON"].ToString();
            MskTC.Text = dr["TC"].ToString();
            TxtMAIL.Text = dr["MAIL"].ToString();
            CmbIL.Text = dr["IL"].ToString();
            CmbILCE.Text = dr["ILCE"].ToString();
            RchADRES.Text = dr["ADRES"].ToString();
            TxtGorev.Text = dr["GOREV"].ToString();
        }
    }
}
