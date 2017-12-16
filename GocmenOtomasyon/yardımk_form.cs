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
    public partial class yardımk_form : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;
        public yardımk_form()
        {
            InitializeComponent();
        }

        private void ykbttn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into tbl_yardim_kurulus(yk_ad) values ('"+ yarktext.Text+"')";
            cmd.ExecuteNonQuery();
            if (yarktext is TextBox)
            {
                if (yarktext.Text == String.Empty)
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

        private void goruntu_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
                string Query = "select * from  tbl_yardim_kurulus ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MyConn2.Open();
 
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
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

        private void yardımk_form_Load(object sender, EventArgs e)
        {
            string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
            string Query = "select * from  tbl_yardim_kurulus ";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MyConn2.Open();

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);

            dataGridView1.DataSource = dTable;

            MyConn2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yardımk_form formkapa = new yardımk_form();
            formkapa.Close();
            tablolar_ekleme form = new tablolar_ekleme();
            form.Show();
            this.Hide();
        }
    }
    }

