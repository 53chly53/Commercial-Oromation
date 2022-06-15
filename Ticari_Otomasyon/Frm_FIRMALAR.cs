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
    public partial class Frm_FIRMALAR : Form
    {
        public Frm_FIRMALAR()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
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
        void cariacıklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchKOD1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtAD.Text = "";
            TxtYETKILIGOREV.Text = "";
            TxtYETKILI.Text = "";
            MskTC.Text = "";
            TxtSEKTOR.Text = "";
            MsKTELEFON1.Text = "";
            MsKTELEFON2.Text = "";
            MsKTELEFON3.Text = "";
            TxtMAIL.Text = "";
            MsKFAX.Text = "";
            CmbIL.Text = "";
            CmbILCE.Text = "";
            CmbVERGI.Text = "";
            RchADRES.Text = "";
            TxtKOD1.Text = "";
            TxtKOD2.Text = "";
            TxtKOD3.Text = "";
            RchKOD1.Text = "";
            RchKOD2.Text = "";
            RchKOD3.Text = "";
            TxtAD.Focus();
        }
        private void FrmFİRMALAR_Load(object sender, EventArgs e)
        {
            firmalistesi();
            sehirlistesi();
            temizle();
            cariacıklamalar();
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl24_Click(object sender, EventArgs e)
        {

        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAD.Text = dr["AD"].ToString();
                TxtYETKILIGOREV.Text = dr["YETKILISTATU"].ToString();
                TxtYETKILI.Text = dr["YETKILIADSOYAD"].ToString();
                MskTC.Text = dr["YETKILITC"].ToString();
                TxtSEKTOR.Text = dr["SEKTOR"].ToString();
                MsKTELEFON1.Text = dr["TELEFON1"].ToString();
                MsKTELEFON2.Text = dr["TELEFON2"].ToString();
                MsKTELEFON3.Text = dr["TELEFON3"].ToString();
                TxtMAIL.Text = dr["MAIL"].ToString();
                MsKFAX.Text = dr["FAX"].ToString();
                CmbIL.Text = dr["IL"].ToString();
                CmbILCE.Text = dr["ILCE"].ToString();
                CmbVERGI.Text = dr["VERGIDAIRE"].ToString();
                RchADRES.Text = dr["ADRES"].ToString();
                RchKOD1.Text = dr["OZELKOD1"].ToString();
                RchKOD2.Text = dr["OZELKOD2"].ToString();
                RchKOD3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3)" +
                "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtYETKILIGOREV.Text);
            komut.Parameters.AddWithValue("@p3", TxtYETKILI.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtSEKTOR.Text);
            komut.Parameters.AddWithValue("@p6", MsKTELEFON1.Text);
            komut.Parameters.AddWithValue("@p7", MsKTELEFON2.Text);
            komut.Parameters.AddWithValue("@p8", MsKTELEFON3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p10", MsKFAX.Text);
            komut.Parameters.AddWithValue("@p11", CmbIL.Text);
            komut.Parameters.AddWithValue("@p12", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p13", CmbVERGI.Text);
            komut.Parameters.AddWithValue("@p14", RchADRES.Text);
            komut.Parameters.AddWithValue("@p15", TxtKOD1.Text);
            komut.Parameters.AddWithValue("@p16", TxtKOD2.Text);
            komut.Parameters.AddWithValue("@p17", TxtKOD3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("firma sisteme kaydedildii", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
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
            CmbILCE.Text = null;
            bgl.baglanti().Close();
        }

        private void CmbILCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbVERGI_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_FIRMALAR where ID=@p1",
               bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            temizle();
            firmalistesi();
        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 WHERE ID=@P18",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtYETKILIGOREV.Text);
            komut.Parameters.AddWithValue("@p3", TxtYETKILI.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtSEKTOR.Text);
            komut.Parameters.AddWithValue("@p6", MsKTELEFON1.Text);
            komut.Parameters.AddWithValue("@p7", MsKTELEFON2.Text);
            komut.Parameters.AddWithValue("@p8", MsKTELEFON3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p10", MsKFAX.Text);
            komut.Parameters.AddWithValue("@p11", CmbIL.Text);
            komut.Parameters.AddWithValue("@p12", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p13", CmbVERGI.Text);
            komut.Parameters.AddWithValue("@p14", RchADRES.Text);
            komut.Parameters.AddWithValue("@p15", TxtKOD1.Text);
            komut.Parameters.AddWithValue("@p16", TxtKOD2.Text);
            komut.Parameters.AddWithValue("@p17", TxtKOD3.Text);
            komut.Parameters.AddWithValue("@p18", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("firma bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
