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
            listelemeform_gocmen frm = new listelemeform_gocmen();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listelemeform_goc goc = new listelemeform_goc();
            goc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listelemeform_meslek frm2 = new listelemeform_meslek();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listelemeform_ulke frm3 = new listelemeform_ulke();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listelemeform_kamp frm4 = new listelemeform_kamp();
            frm4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listelemeform_sehir frm5 = new listelemeform_sehir();
            frm5.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listelemeform_yardımk frm6 = new listelemeform_yardımk();
            frm6.Show();
            this.Hide();


        }
    }
}
