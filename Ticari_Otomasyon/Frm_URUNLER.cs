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
    public partial class Frm_URUNLER : Form
    {
        public Frm_URUNLER()
        {
            InitializeComponent();
        }


        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        void temizle()
        {
            TxtID.Text = "";
            TxtAD.Text = "";
            TxtMARKA.Text = "";
            TxtMODEL.Text = "";
            MskYIL.Text = "";
            NudADET.Text = "";
            TxtALISFIYAT.Text = "";
            TxtSATISFIYAT.Text = "";
            RchDETAY.Text = "";
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt); // data adaptırın içini datatable ile doldur
            gridControl1.DataSource = dt;
        }
        private void FrmURUNLER_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNADI,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtMARKA.Text);
            komut.Parameters.AddWithValue("@p3", TxtMODEL.Text);
            komut.Parameters.AddWithValue("@p4", MskYIL.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudADET.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtALISFIYAT.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSATISFIYAT.Text));
            komut.Parameters.AddWithValue("@p8", RchDETAY.Text);
            komut.ExecuteNonQuery(); // dml komutlarını çalıştırır
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1",
                bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["ID"].ToString();
            TxtAD.Text = dr["URUNADI"].ToString();
            TxtMARKA.Text = dr["MARKA"].ToString();
            TxtMODEL.Text = dr["MODEL"].ToString();
            MskYIL.Text = dr["YIL"].ToString();
            NudADET.Text = dr["ADET"].ToString();
            TxtALISFIYAT.Text = dr["ALISFIYAT"].ToString();
            TxtSATISFIYAT.Text = dr["SATISFIYAT"].ToString();
            RchDETAY.Text = dr["DETAY"].ToString();
        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komutgnncelle = new SqlCommand("update TBL_URUNLER set URUNADI=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 WHERE ID=@P9", bgl.baglanti());
            komutgnncelle.Parameters.AddWithValue("@p1", TxtAD.Text);
            komutgnncelle.Parameters.AddWithValue("@p2", TxtMARKA.Text);
            komutgnncelle.Parameters.AddWithValue("@p3", TxtMODEL.Text);
            komutgnncelle.Parameters.AddWithValue("@p4", MskYIL.Text);
            komutgnncelle.Parameters.AddWithValue("@p5", int.Parse((NudADET.Value).ToString()));
            komutgnncelle.Parameters.AddWithValue("@p6", decimal.Parse(TxtALISFIYAT.Text));
            komutgnncelle.Parameters.AddWithValue("@p7", decimal.Parse(TxtSATISFIYAT.Text));
            komutgnncelle.Parameters.AddWithValue("@p8", RchDETAY.Text);
            komutgnncelle.Parameters.AddWithValue("@p9", TxtID.Text);
            komutgnncelle.ExecuteNonQuery(); // dml komutlarını çalıştırır
            bgl.baglanti().Close();
            MessageBox.Show("Ürün bilgisi güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
