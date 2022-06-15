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
    public partial class Frm_HAREKETLER : Form
    {
        public Frm_HAREKETLER()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }
        
        void Müsterilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Musterihareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmHAREKETLER_Load(object sender, EventArgs e)
        {
            Firmalistesi();
            Müsterilistesi();
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
