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
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            BtnGırısYap.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BtnGırısYap.BackColor = Color.LightSeaGreen;
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnGırısYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_ADMIN where Kullaniciad=@t1 and Sifre=@b2",bgl.baglanti());
            komut.Parameters.AddWithValue("@t1",TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@b2",TxtSıfre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.kullanici = TxtKullanıcıAd.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da şifre","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
