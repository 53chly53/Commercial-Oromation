using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Frm_Raporlar : Form
    {
        public Frm_Raporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'celalprojeDataSet.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.celalprojeDataSet.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'celalprojeDataSet.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.celalprojeDataSet.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'celalprojeDataSet.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.celalprojeDataSet.TBL_FIRMALAR);
            // TODO: This line of code loads data into the 'celalprojeDataSet.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.celalprojeDataSet.TBL_MUSTERILER);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {

        }
    }
}
