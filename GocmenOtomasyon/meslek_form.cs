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
    public partial class meslek_form : Form
    {

        MySqlConnection con = DaoClass.GetMySqlConnection();
        private MySqlDataReader dr;
        public meslek_form()
        {
            InitializeComponent();
        }

        private void meslekbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO tbl_meslek(meslek_ad)VALUES('" + meslektxb.Text + "')";
            cmd.ExecuteNonQuery();
            if (meslektxb is TextBox)
            {
                if (meslektxb.Text == String.Empty)
                {
                    MessageBox.Show("Bu alan boş bırakılamaz!");
                }
                else
                {
                    MessageBox.Show("Kayıt veritabanına eklendi, işlemi görüntülemek için görüntüle butonuna basınız..");
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
                string Query = "SELECT * FROM  tbl_meslek ";
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

        }
        private void button2_Click(object sender, EventArgs e)
        {
            meslek_form formkapa = new meslek_form();
            formkapa.Close();
            tablolar_ekleme form = new tablolar_ekleme();
            form.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
 }

