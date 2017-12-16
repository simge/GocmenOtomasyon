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
    public partial class kamp_guncelleme_ekrani : Form
    {
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;
        public kamp_guncelleme_ekrani()
        {
            InitializeComponent();
        }

        private void kamp_guncelleme_ekrani_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            sda = new MySqlDataAdapter(@"SELECT `kamp_id`, `sehir_id`, `kamp_ad`, `kurul_trh` FROM `tbl_kamp`", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void yenile_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            sda = new MySqlDataAdapter(@"SELECT `kamp_id`, `sehir_id`, `kamp_ad`, `kurul_trh` FROM `tbl_kamp`", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void guncel_btn_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
