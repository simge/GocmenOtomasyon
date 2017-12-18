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
    public partial class meslek_kayıt_silme : Form
     
    {
        MySqlConnection baglanti;
        public meslek_kayıt_silme()
        {
            InitializeComponent();
        }
        private void baglan()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder(@"server=localhost;user id=root;database=gocmenotomasyon");

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            string sql = "SELECT * FROM tbl_meslek";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = DaoClass.GetMySqlDataAdapter();
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
            string sql = "DELETE FROM tbl_meslek WHERE meslek_id=  '" + giristxb.Text + "'";
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

        private void yenile_Click_1(object sender, EventArgs e)
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder(@"server=localhost;user id=root;database=gocmenotomasyon");

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            string sql = "SELECT * FROM tbl_meslek";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = DaoClass.GetMySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;
            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meslek_kayıt_silme formkapa = new meslek_kayıt_silme();
            formkapa.Close();
            kayıt_silme_formu form = new kayıt_silme_formu();
            form.Show();
            this.Hide();
        }
    }
}
