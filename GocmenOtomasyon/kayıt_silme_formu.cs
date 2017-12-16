using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GocmenOtomasyon
{
    public partial class kayıt_silme_formu : Form
    {
        public kayıt_silme_formu()
        {
            InitializeComponent();
        }

        private void gocmen_liste_Click(object sender, EventArgs e)
        {
            gocmen_kayıt_silme frm = new gocmen_kayıt_silme();
            frm.Show();
            this.Hide();
        }

        private void goc_listeleme_Click(object sender, EventArgs e)
        {
            goc_kayit_silme frm = new goc_kayit_silme();
            frm.Show();
            this.Hide();
        }

        private void meslek_listeleme_Click(object sender, EventArgs e)
        {
            meslek_kayıt_silme frm = new meslek_kayıt_silme();
            frm.Show();
            this.Hide();
        }

        private void sehir_listeleme_Click(object sender, EventArgs e)
        {
            sehir_silme_formu frm = new sehir_silme_formu();
            frm.Show();
            this.Hide();
        }

        private void ulke_listeleme_Click(object sender, EventArgs e)
        {
            ulke_silme_formu frm = new ulke_silme_formu();
            frm.Show();
            this.Hide();
        }

        private void kurulus_listeleme_Click(object sender, EventArgs e)
        {
            yardımk_silme_form frm = new yardımk_silme_form();
            frm.Show();
            this.Hide();
        }

        private void kamp_listeleme_Click(object sender, EventArgs e)
        {
            kamp_silme_formu frm = new kamp_silme_formu();
            frm.Show();
            this.Hide();
        }
    }
}
