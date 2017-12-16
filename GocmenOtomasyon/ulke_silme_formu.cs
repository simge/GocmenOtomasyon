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
    public partial class ulke_silme_formu : Form
    {
        MySqlConnection baglanti;
        public ulke_silme_formu()
        {
            InitializeComponent();
        }
        private void baglan()
        {
            string bag;


            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder(@"server=localhost;user id=root;database=gocmenotomasyon");

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            string sql = "SELECT * FROM tbl_gocmen_ulkesi";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;
            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void sil_Click(object sender, EventArgs e)
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder(@"server=localhost;user id=root;database=gocmenotomasyon");
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
            string sql = "DELETE FROM tbl_gocmen_ulkesi WHERE ulke_id=  '" + giristxb.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;

            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            string bag;


            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder(@"server=localhost;user id=root;database=gocmenotomasyon");

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            string sql = "SELECT * FROM tbl_gocmen_ulkesi";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;
            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
