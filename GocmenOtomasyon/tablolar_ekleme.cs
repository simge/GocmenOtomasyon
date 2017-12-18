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
    public partial class tablolar_ekleme : Form
    {
        

        public tablolar_ekleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gocmen_ekleme_formu form1 = new gocmen_ekleme_formu();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goc_ekle form_goc = new goc_ekle();
            form_goc.Show();
            this.Hide();
        }

        private void sehir_bttn_Click(object sender, EventArgs e)
        {
            sehir_ekle form_sehir = new sehir_ekle();
            form_sehir.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ulke_ekle_form form_ulke = new ulke_ekle_form();
            form_ulke.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meslek_form form_meslek = new meslek_form();
            form_meslek.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kamp_form form_kamp = new kamp_form();
            form_kamp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yardımk_form form_yk = new yardımk_form();
            form_yk.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tablolar_ekleme formkapa = new tablolar_ekleme();
            formkapa.Close();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void kk_btn_Click(object sender, EventArgs e)
        {
            baglanti_tablosu frm = new baglanti_tablosu();
            frm.Show();
            this.Hide();
        }
    }
}
