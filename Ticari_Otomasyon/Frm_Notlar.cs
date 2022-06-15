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
    public partial class Frm_Notlar : Form
    {
        public Frm_Notlar()
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
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
        }
        void temizle()
        {
            TxtID.Text = "";
            MskTARIH.Text = "";
            MskSAAT.Text = "";
            TxtBASLIK.Text = "";
            RchDETAY.Text = "";
            TxtOLUSTURAN.Text = "";
            TxtHITAP.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTARIH.Text);
            komut.Parameters.AddWithValue("@p2", MskSAAT.Text);
            komut.Parameters.AddWithValue("@p3", TxtBASLIK.Text);
            komut.Parameters.AddWithValue("@p4", RchDETAY.Text);
            komut.Parameters.AddWithValue("@p5", TxtOLUSTURAN.Text);
            komut.Parameters.AddWithValue("@p6", TxtHITAP.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not bilgisi kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (true)
            {
                TxtID.Text = dr["ID"].ToString();
                MskTARIH.Text = dr["TARIH"].ToString();
                MskSAAT.Text = dr["SAAT"].ToString();
                TxtBASLIK.Text = dr["BASLIK"].ToString();
                RchDETAY.Text = dr["DETAY"].ToString();
                TxtOLUSTURAN.Text = dr["OLUSTURAN"].ToString();
                TxtHITAP.Text = dr["HITAP"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_NOTLAR where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not bilgisi silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@P7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTARIH.Text);
            komut.Parameters.AddWithValue("@p2", MskSAAT.Text);
            komut.Parameters.AddWithValue("@p3", TxtBASLIK.Text);
            komut.Parameters.AddWithValue("@p4", RchDETAY.Text);
            komut.Parameters.AddWithValue("@p5", TxtOLUSTURAN.Text);
            komut.Parameters.AddWithValue("@p6", TxtHITAP.Text);
            komut.Parameters.AddWithValue("@p7", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_NotDetay fr = new Frm_NotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
