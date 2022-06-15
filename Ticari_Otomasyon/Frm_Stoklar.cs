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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class Frm_Stoklar : Form
    {
        public Frm_Stoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("İstanbul", 4));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Adana", 4));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ankara", 4));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("İzmir", 4));

            SqlDataAdapter da = new SqlDataAdapter("Select URUNADI,Sum(ADET) As 'Miktar' From TBL_URUNLER Group By URUNADI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //charda stok miktarı listeleme
            SqlCommand komut = new SqlCommand("Select URUNADI,SUM(ADET) as 'Miktar' From TBL_URUNLER Group By URUNADI", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

            //charta firma şehir sayısı çekme
            SqlCommand komut2 = new SqlCommand("Select IL,Count(*) From TBL_FIRMALAR Group By IL", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();
        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl2_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_StokDetay fr = new Frm_StokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //grid viewde seçmiş olduğun satırın verisini al ama satırın bulunduğu alan                         
            if (dr != null)
            {
                fr.ad = dr["URUNADI"].ToString();
            }
            fr.Show();
        }
    }
}
