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
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class Frm_MAIL : Form
    {
        public Frm_MAIL()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMAIL_Load(object sender, EventArgs e)
        {
            TxtMailAdres.Text = mail;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage(); //mesajım diye nesne türetildi
            SmtpClient istemci = new SmtpClient(); //istemci diye nesne türetildi kapıyı tıklatma işlemi yapıyor)
            istemci.Credentials = new System.Net.NetworkCredential("a7312998", "consolewriteline"); //(kendi mail adresini ve şifreni yaz) //mesajın kimden gönderildiği
            //istemci.Credentials = istemcinin kimliği
            //NetworkCredential=ağ kimliği
            istemci.Port = 587; //port numarası
            istemci.Host = "smtp.live.com";//istemcinin sunucusu
            istemci.EnableSsl = true; //mesajı şifrelemek
            mesajım.To.Add(TxtMesaj.Text);//mesajımıniçerisine ekle (mesajı /maili kime göndereceğimiz)
            mesajım.From = new MailAddress("a7312998"); //mesajın kimden gönderildiği
            mesajım.Subject = TxtKonu.Text; //mesajın konusu
            mesajım.Body = TxtKonu.Text; // mesajım.Body =içerik kısmı 
            istemci.Send(mesajım); //mesajımı gönder
            //hata alırsan mutlaka google da arat çünkü hotmailde veya gmailde bazı güvenlik sebepleriyle engelliyebiliyor bu mailleri.
            //en azından nasıl güvenlik duvarını kaldırcağınız görmüş olurusn
        }

        private void MailAdresi_Click(object sender, EventArgs e)
        {

        }
    }
}
