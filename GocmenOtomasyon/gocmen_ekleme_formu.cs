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
    public partial class gocmen_ekleme_formu : Form
    {

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;
        private MySqlDataReader dr1;
        private MySqlDataReader dr2;
        private MySqlDataReader dr3;
        private MySqlDataReader dr4;
        
        public gocmen_ekleme_formu()
        {
            InitializeComponent();
            
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            ComboboxItem gocitem = (ComboboxItem)goc.SelectedItem;
            string goc_value = gocitem.Value.ToString();

            ComboboxItem ulkeitem = (ComboboxItem)ulke.SelectedItem;
            string ulke_value = ulkeitem.Value.ToString();

            ComboboxItem sehiralaniitem = (ComboboxItem)sehiralani.SelectedItem;
            string sehiralani_value = sehiralaniitem.Value.ToString();

            ComboboxItem kampalaniitem = (ComboboxItem)kampalani.SelectedItem;
            string kampalani_value = kampalaniitem.Value.ToString();

            ComboboxItem meslekalaniitem = (ComboboxItem)meslekalani.SelectedItem;
            string meslekalani_value = meslekalaniitem.Value.ToString();


            cmd.CommandText = "insert into tbl_gocmen (goc_id, ulke_id, sehir_id, kamp_id, meslek_id, gocmen_ad, gocmen_soyad, gocmen_yas, gocmen_cinsiyet, gocmen_egitim_duzeyi )values('" + Int32.Parse(goc_value) + "', '" + Int32.Parse(ulke_value) + "', '" + Int32.Parse(sehiralani_value) + "', '" + Int32.Parse(kampalani_value) + "','" + Int32.Parse(meslekalani_value) + "', '" + ad.Text+"', '"+soyad.Text+ "', '" + yas.Text + "', '" + cinsiyet.Text + "','" + egitim_duzeyi.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("İşlem veritabanında kaydedildi görüntülemek için görüntüle butonuna basınız..");
            con.Close();
            
        }

        private void goruntu_btn_Click(object sender, EventArgs e)
        {
            
            try
                {
                    string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
                    //Sorgu Görüntüleme
                    string Query = "select * from  tbl_gocmen ";
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

        private void ekle_forms_Load(object sender, EventArgs e)
        {
            string MyConnection2 = "server=localhost;user id=root;database=gocmenotomasyon";
            //Sorgu Görüntüleme
            string Query = "select * from  tbl_gocmen ";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MyConn2.Open();

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);

            dataGridView1.DataSource = dTable;
            MyConn2.Close();

            con.Open();
            MySqlCommand goc_connect = con.CreateCommand();
            goc_connect.CommandType = CommandType.Text;
            goc_connect.CommandText = "select * from tbl_goc";
            dr = goc_connect.ExecuteReader();

            while (dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr.GetString("goc_tur");
                item.Value = dr.GetString("goc_id");
                goc.Items.Add(item);
                
            }
            con.Close();

            con.Open();
            MySqlCommand ulke_connect = con.CreateCommand();
            ulke_connect.CommandType = CommandType.Text;
            ulke_connect.CommandText = "select * from tbl_gocmen_ulkesi";
            dr1 = ulke_connect.ExecuteReader();

          
            while (dr1.Read())
            {
                ComboboxItem item1 = new ComboboxItem();
                item1.Text = dr1.GetString("ulke_ad");
                item1.Value = dr1.GetString("ulke_id");
                ulke.Items.Add(item1);
                
            }
            con.Close();

            con.Open();
            MySqlCommand sehir_connect = con.CreateCommand();
            sehir_connect.CommandType = CommandType.Text;
            sehir_connect.CommandText = "select * from tbl_kaldigi_sehir";
            dr2 = sehir_connect.ExecuteReader();


            while (dr2.Read())
            {
                ComboboxItem item2 = new ComboboxItem();
                item2.Text = dr2.GetString("sehir_ad");
                item2.Value = dr2.GetString("sehir_id");
                sehiralani.Items.Add(item2);

            }
            con.Close();

            con.Open();
            MySqlCommand kampc_connect = con.CreateCommand();
            kampc_connect.CommandType = CommandType.Text;
            kampc_connect.CommandText = "select * from tbl_kamp";
            dr3 = kampc_connect.ExecuteReader();

            while (dr3.Read())
            {
                ComboboxItem item3 = new ComboboxItem();
                item3.Text = dr3.GetString("kamp_ad");
                item3.Value = dr3.GetString("kamp_id");
                kampalani.Items.Add(item3);

            }
            con.Close();

            con.Open();
            MySqlCommand meslek_connect = con.CreateCommand();
            meslek_connect.CommandType = CommandType.Text;
            meslek_connect.CommandText = "select * from tbl_meslek";
            dr4 = meslek_connect.ExecuteReader();

            while (dr4.Read())
            {
                ComboboxItem item4 = new ComboboxItem();
                item4.Text = dr4.GetString("meslek_ad");
                item4.Value = dr4.GetString("meslek_id");
                meslekalani.Items.Add(item4);

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ad.Text = row.Cells["gocmen_ad"].Value.ToString();
                soyad.Text = row.Cells["gocmen_soyad"].Value.ToString();
                yas.Text = row.Cells["gocmen_yas"].Value.ToString();
                cinsiyet.Text = row.Cells["gocmen_cinsiyet"].Value.ToString();
                egitim_duzeyi.Text = row.Cells["gocmen_egitim_duzeyi"].Value.ToString();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
