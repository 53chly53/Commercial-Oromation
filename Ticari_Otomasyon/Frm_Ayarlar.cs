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
    public partial class Frm_Ayarlar : Form
    {
        public Frm_Ayarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_ADMIN",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            TxtKullanıcıAdı.Text = "";
            TxtSifre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Kaydet")
            {

                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKullanıcıAdı.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin sisteme kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (button1.Text == "Güncelle")
            {
                SqlCommand komut1 = new SqlCommand("update TBL_ADMIN set Sifre=@p2 where Kullaniciad=@p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1",TxtKullanıcıAdı.Text);
                komut1.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("kayıt güncellendi","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr!=null)
            {
                TxtKullanıcıAdı.Text = dr["Kullaniciad"].ToString();
                TxtSifre.Text = dr["Sifre"].ToString();
            }
        }

        private void TxtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            if (TxtKullanıcıAdı.Text != "")
            {
                button1.Text = "Güncelle";
                button1.BackColor = Color.GreenYellow;
            }
            else
            {
                button1.Text = "Kaydet";
                button1.BackColor = Color.MediumTurquoise;
            }
        }
    }
}
