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
    public partial class sehir_ekle : Form
    {
        MySqlConnection con = DaoClass.GetMySqlConnection();
        private MySqlDataReader dr;
        public sehir_ekle()
        {
            InitializeComponent();
        }

        private void shrekle_bttn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO tbl_kaldigi_sehir(sehir_ad)values('" + sehir_tbox.Text + "')";


            if (sehir_tbox is TextBox)
            {
                if (sehir_tbox.Text == String.Empty)
                {
                    MessageBox.Show("Bu alan boş bırakılamaz!");
                }
                else
                {
                    MessageBox.Show("Kayıt veritabanına eklendi, işlemi görüntülemek için görüntüle butonuna basınız..");
                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        }
        private void button2_Click(object sender, EventArgs e)
        {
            sehir_ekle formkapa = new sehir_ekle();
            formkapa.Close();
            tablolar_ekleme form = new tablolar_ekleme();
            form.Show();
            this.Hide();
        }
        private void sehir_tbox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
 }

