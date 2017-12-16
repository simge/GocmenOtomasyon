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
    public partial class sehir_guncelleme_ekrani : Form
    {
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;
        public sehir_guncelleme_ekrani()
        {
            InitializeComponent();
        }

        private void sehir_guncelleme_ekrani_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            sda = new MySqlDataAdapter(@"SELECT `sehir_id`, `sehir_ad` FROM `tbl_kaldigi_sehir`", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void yenile_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            sda = new MySqlDataAdapter(@"SELECT `sehir_id`, `sehir_ad` FROM `tbl_kaldigi_sehir`", con);
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
