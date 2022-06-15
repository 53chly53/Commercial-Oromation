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
    public partial class Frm_GIDERLER : Form
    {
        public Frm_GIDERLER()
        {
            InitializeComponent();
        }

        private void TxtID_EditValueChanged(object sender, EventArgs e)
        {

        }
       
        sqlbaglantisi bgl = new sqlbaglantisi();
        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER Order By ID Asc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Frm_GIDERLER_Load(object sender, EventArgs e)
        {
            giderlistesi();
            temizle();
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAY.Text);
            komut.Parameters.AddWithValue("@p2", CmbYıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtELEKTRIK.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSU.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDOGALGAZ.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtINTERNET.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxTMAASLAR.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEKSTRA.Text));
            komut.Parameters.AddWithValue("@p9", RchNOTLAR.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tabloya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            //temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr !=null)
            {
                TxtID.Text = dr["ID"].ToString();
                CmbAY.Text = dr["AY"].ToString();
                CmbYıl.Text=dr["YIL"].ToString();
                TxtELEKTRIK.Text = dr["ELEKTRIK"].ToString();
                TxtSU.Text = dr["SU"].ToString();
                TxtDOGALGAZ.Text = dr["DOGALGAZ"].ToString();
                TxtINTERNET.Text = dr["INTERNET"].ToString();
                TxTMAASLAR.Text = dr["MAASLAR"].ToString();
                TxtEKSTRA.Text = dr["EKSTRA"].ToString();
                RchNOTLAR.Text = dr["NOTLAR"].ToString();
            }
        }
        void temizle()
        {
            TxtID.Text = "";
            CmbAY.Text = "";
            CmbYıl.Text = "";
            TxtELEKTRIK.Text = "";
            TxtSU.Text = "";
            TxtDOGALGAZ.Text = "";
            TxtINTERNET.Text = "";
            TxTMAASLAR.Text = "";
            TxtEKSTRA.Text = "";
            RchNOTLAR.Text = "";
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);//parametre 1 i txt id den alıcak
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderlistesi();
            MessageBox.Show("gider sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAY.Text);
            komut.Parameters.AddWithValue("@p2", CmbYıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtELEKTRIK.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSU.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDOGALGAZ.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtINTERNET.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxTMAASLAR.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEKSTRA.Text));
            komut.Parameters.AddWithValue("@p9", RchNOTLAR.Text);
            komut.Parameters.AddWithValue("@p10", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void CmbAY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbYıl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
