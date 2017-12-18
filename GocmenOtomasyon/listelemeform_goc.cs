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
    public partial class listelemeform_goc : Form

    {
        MySqlConnection con = new MySqlConnection();

        public listelemeform_goc()
        {
            InitializeComponent();
        }

        private void lst_goc_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
                //Display query
                string Query = "select * from  tbl_goc ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);


                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.

                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MySqlConnection con1 = DaoClass.GetMySqlConnection();
            con1.Open();
            string query = "SELECT COUNT(goc_id) FROM tbl_goc";
            MySqlCommand command = new MySqlCommand(query, con1);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                sayici.Text = dr.GetString(0);
            }

            con1.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void don_btn_Click(object sender, EventArgs e)
        {
            listelemeform_goc formkapa = new listelemeform_goc();
            formkapa.Close();
            listeleme_formu form = new listeleme_formu();
            form.Show();
            this.Hide();
        }
    }
}
