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
    public partial class listelemeform_sehir : Form
    {
        MySqlConnection con = DaoClass.GetMySqlConnection();
        public listelemeform_sehir()
        {
            InitializeComponent();
        }

        private void lst_goc_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
                string Query = "SELECT * FROM  tbl_kaldigi_sehir ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MyConn2.Open();
                MySqlDataAdapter MyAdapter = DaoClass.GetMySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);


                dataGridView1.DataSource = dTable;

                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MySqlConnection con1 = DaoClass.GetMySqlConnection();
            con1.Open();
            string query = "SELECT COUNT(sehir_id) FROM tbl_kaldigi_sehir";
            MySqlCommand command = new MySqlCommand(query, con1);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                sayici.Text = dr.GetString(0);
            }

            con1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listelemeform_sehir formkapa = new listelemeform_sehir();
            formkapa.Close();
            listeleme_formu form = new listeleme_formu();
            form.Show();
            this.Hide();
        }
    }
}
