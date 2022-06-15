using System;
using System.Data.SqlClient;
using System.Linq;
namespace Ticari_Otomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {   //ev
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J3N7L9V;Initial Catalog=celalproje;Integrated Security=True");
            baglan.Open();
            return baglan;

            //yedek
            //SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=celalproje;Integrated Security=True");
            //baglan.Open();
            //return baglan;
        }
    }
}
