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
    public partial class kamp_form : Form
    {
        MySqlConnection con = DaoClass.GetMySqlConnection();
        private MySqlDataReader dr;
        public kamp_form()
        {
            InitializeComponent();
        }

      
        private void kampbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            ComboboxItem sehiritem = (ComboboxItem)kamp_cbx.SelectedItem;
            string sehir_value = sehiritem.Value.ToString();
            if (kampadi is ComboboxItem)
            {
                if (kampadi.Text == String.Empty)
                {
                    MessageBox.Show("Bu alan boş bırakılamaz!");
                }
                else
                {
                    MessageBox.Show("Kayıt veritabanına eklendi, işlemi görüntülemek için görüntüle butonuna basınız..");
                }
            }

            cmd.CommandText = "INSERT INTO tbl_kamp(sehir_id,kamp_ad, kurul_trh) values ('" + Int32.Parse(sehir_value) + "','" + kampadi.Text + "','" + kamptrh.Text + "')";
            cmd.ExecuteNonQuery();
            if (kampadi is TextBox)
            {
                if (kampadi.Text == String.Empty)
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

        private void kamp_form_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand sehir_connect = con.CreateCommand();
            sehir_connect.CommandType = CommandType.Text;
            sehir_connect.CommandText = "SELECT * FROM tbl_kaldigi_sehir";
            dr = sehir_connect.ExecuteReader();

            while (dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr.GetString("sehir_ad");
                item.Value = dr.GetString("sehir_id");
                kamp_cbx.Items.Add(item);

            }
            con.Close();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void gorun_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
                //Display query
                string Query = "SELECT * FROM  tbl_kamp ";
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
        private void don_btn_Click(object sender, EventArgs e)
        {
            kamp_form formkapa = new kamp_form();
            formkapa.Close();
            tablolar_ekleme form = new tablolar_ekleme();
            form.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void kamp_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
 }

