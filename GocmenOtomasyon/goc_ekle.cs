using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GocmenOtomasyon
{
    public partial class goc_ekle : Form

    {
 
        public goc_ekle()
        {
            InitializeComponent();
            
        }

        private void ekleme_button_Click(object sender, EventArgs e)
        {
            MySqlConnection con =  DaoClass.GetMySqlConnection();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO tbl_goc(goc_tur,goc_trh)VALUES('" + goc_tur.Text + "','" + goc_trh.Text + "')";
            cmd.ExecuteNonQuery();
            if (goc_tur is TextBox)
            {
                if (goc_tur.Text == String.Empty)
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
        
        private void goc_goruntu_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM  tbl_goc ";
                MySqlConnection con = DaoClass.GetMySqlConnection();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                con.Open();
                MySqlDataAdapter adapter = DaoClass.GetMySqlDataAdapter();
                adapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }
        private void geri_btn_Click(object sender, EventArgs e)
        {
            goc_ekle formkapa = new goc_ekle();
            formkapa.Close();
            tablolar_ekleme form = new tablolar_ekleme();
            form.Show();
            this.Hide();
        }
        private void goc_ekle_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goc_trh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void goctarihi_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

      
    }
}

