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
    public partial class guncelleme_form_ekranı : Form
    {
        public guncelleme_form_ekranı()
        {
            InitializeComponent();
        }

        private void gocmen_liste_Click(object sender, EventArgs e)
        {
            gocmen_guncel_form frm = new gocmen_guncel_form();
            frm.Show();
            this.Hide();
        }

        private void goc_listeleme_Click(object sender, EventArgs e)
        {
            goc_guncelleme_ekrani frm = new goc_guncelleme_ekrani();
            frm.Show();
            this.Hide();
        }

        private void meslek_listeleme_Click(object sender, EventArgs e)
        {
            meslek_guncelleme_ekrani frm = new meslek_guncelleme_ekrani();
            frm.Show();
            this.Hide();

        }

        private void ulke_listeleme_Click(object sender, EventArgs e)
        {
            ulke_guncelleme_ekrani frm = new ulke_guncelleme_ekrani();
            frm.Show();
            this.Hide();
        }

        private void kamp_listeleme_Click(object sender, EventArgs e)
        {
            kamp_guncelleme_ekrani frm = new kamp_guncelleme_ekrani();
            frm.Show();
            this.Hide();
        }

        private void sehir_listeleme_Click(object sender, EventArgs e)
        {
            sehir_guncelleme_ekrani frm = new sehir_guncelleme_ekrani();
            frm.Show();
            this.Hide();
        }

        private void kurulus_listeleme_Click(object sender, EventArgs e)
        {
            yardimk_guncelleme_ekrani frm = new yardimk_guncelleme_ekrani();
            frm.Show();
            this.Hide();
        }
    }
}
