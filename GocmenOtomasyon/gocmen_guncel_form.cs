using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace GocmenOtomasyon
{
    public partial class gocmen_guncel_form : Form
    {
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;
        public gocmen_guncel_form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            sda = new MySqlDataAdapter(@"SELECT `gocmen_id`, `goc_id`, `ulke_id`, `sehir_id`, `kamp_id`, `meslek_id`, `gocmen_ad`, `gocmen_soyad`, `gocmen_yas`, `gocmen_cinsiyet`, `gocmen_egitim_duzeyi` FROM `tbl_gocmen`", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void soyad_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guncel_btn_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void yenile_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            sda = new MySqlDataAdapter(@"SELECT `gocmen_id`, `goc_id`, `ulke_id`, `sehir_id`, `kamp_id`, `meslek_id`, `gocmen_ad`, `gocmen_soyad`, `gocmen_yas`, `gocmen_cinsiyet`, `gocmen_egitim_duzeyi` FROM `tbl_gocmen`",con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
