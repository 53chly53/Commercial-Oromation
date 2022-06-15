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
    public partial class Frm_BANKALAR : Form
    {
        public Frm_BANKALAR()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void temizle()
        {
            TxtID.Text = "";
             TxtBANKAADI.Text ="";
             CmbIL.Text = "";
            CmbILCE.Text = "";
            TxtSUBE.Text = "";
            TxtIBAN.Text = "";
            TxtHESAPNO.Text = "";
            TxtYETKILI.Text = "";
            MskTELEFON1.Text = "";
            MskTARIH.Text = "";
            TxtHESAPTURU.Text = "";
            lookUpEdit1.Text = "";
            TxtID.Focus();
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select sehir From iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

      
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
      
        private void Frm_BANKALAR_Load(object sender, EventArgs e)
        {
            listele();
            firmalistesi();
            sehirlistesi();
        }
        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID"; // lookUpEdit1.EditValue); komutu ile düzenlencek değer
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;

        }
       
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID)" +
               "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBANKAADI.Text);
            komut.Parameters.AddWithValue("@p2", CmbIL.Text);
            komut.Parameters.AddWithValue("@p3", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p4", TxtSUBE.Text);
            komut.Parameters.AddWithValue("@p5", TxtIBAN.Text);
            komut.Parameters.AddWithValue("@p6", TxtHESAPNO.Text);
            komut.Parameters.AddWithValue("@p7", TxtYETKILI.Text);
            komut.Parameters.AddWithValue("@p8", MskTELEFON1.Text);
            komut.Parameters.AddWithValue("@p9", MskTARIH.Text); 
            komut.Parameters.AddWithValue("@p10", TxtHESAPTURU.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("BANKA bilgisi sisteme kaydedildii", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
           
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_BANKALAR where ID=@p1",
               bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka bilgisi sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e) 
        {
            SqlCommand komut = new SqlCommand("Update TBL_BANKALAR set BANKAADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 WHERE ID=@P12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBANKAADI.Text);
            komut.Parameters.AddWithValue("@p2", CmbIL.Text);
            komut.Parameters.AddWithValue("@p3", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p4", TxtSUBE.Text);
            komut.Parameters.AddWithValue("@p5", TxtIBAN.Text);
            komut.Parameters.AddWithValue("@p6", TxtHESAPNO.Text);
            komut.Parameters.AddWithValue("@p7", TxtYETKILI.Text);
            komut.Parameters.AddWithValue("@p8", MskTELEFON1.Text);
            komut.Parameters.AddWithValue("@p9", MskTARIH.Text);
            komut.Parameters.AddWithValue("@p10", TxtHESAPTURU.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", TxtID.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select il from iller where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            CmbILCE.Text = null;
        }

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtBANKAADI.Text = dr["BANKAADI"].ToString();
                CmbIL.Text = dr["IL"].ToString();
                CmbILCE.Text = dr["ILCE"].ToString();
                TxtSUBE.Text = dr["SUBE"].ToString();
                TxtIBAN.Text = dr["IBAN"].ToString();
                TxtHESAPNO.Text = dr["HESAPNO"].ToString();
                TxtYETKILI.Text = dr["YETKILI"].ToString();
                MskTELEFON1.Text = dr["TELEFON"].ToString();
                MskTARIH.Text = dr["TARIH"].ToString(); 
                TxtHESAPTURU.Text = dr["HESAPTURU"].ToString();
                //lookUpEdit1 = dr["FIRMAID"].ToString();
            }
        }

        private void CmbIL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from ilceler where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);
            }
            CmbILCE.Text = null;
            bgl.baglanti().Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
