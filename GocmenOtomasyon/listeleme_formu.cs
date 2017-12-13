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
    public partial class listeleme_formu : Form
    {
        public listeleme_formu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle_forms frm = new ekle_forms();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goc_ekle frm1 = new goc_ekle();
            frm1.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meslek_form frm2 = new meslek_form();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ulke_ekle_form frm3 = new ulke_ekle_form();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kamp_form frm4 = new kamp_form();
            frm4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sehir_ekle frm5 = new sehir_ekle();
            frm5.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            yardımk_form frm6 = new yardımk_form();
            frm6.Show();
            this.Hide();


        }
    }
}
