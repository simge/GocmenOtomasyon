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
    public partial class baglanti_tablosu : Form
    {
        MySqlConnection con = DaoClass.GetMySqlConnection();
        private MySqlDataReader dr;
        private MySqlDataReader dr1;
        public baglanti_tablosu()
        {
            InitializeComponent();
        }
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            ComboboxItem kampitem = (ComboboxItem)kamp_id.SelectedItem;
            string kamp_value = kampitem.Value.ToString();

            ComboboxItem ykitem = (ComboboxItem)yk_id.SelectedItem;
            string yk_value = ykitem.Value.ToString();

            cmd.CommandText = "insert into kamp_kurulus (kamp_id, yk_id)values('" + Int32.Parse(kamp_value) + "', '" + Int32.Parse(yk_value) + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("İşlem veritabanında kaydedildi görüntülemek için görüntüle butonuna basınız..");
            con.Close();
        }
        private void gorn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT k.kamp_id , k.kamp_ad , yk.yk_id , yk.yk_ad FROM tbl_kamp AS k INNER JOIN kamp_kurulus AS kk ON k.kamp_id = kk.kamp_id INNER JOIN tbl_yardim_kurulus AS yk ON kk.yk_id = yk.yk_id ORDER BY k.kamp_id ";
                MySqlConnection MyConn2 = DaoClass.GetMySqlConnection();
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
        private void baglanti_tablosu_Load(object sender, EventArgs e)
        {
            MySqlConnection MyConn2 = DaoClass.GetMySqlConnection();
            string Query = "SELECT * FROM  kamp_kurulus ";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MyConn2.Open();

            MySqlDataAdapter MyAdapter = DaoClass.GetMySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);

            dataGridView1.DataSource = dTable;
            MyConn2.Close();

            con.Open();
            MySqlCommand kk_connect = con.CreateCommand();
            kk_connect.CommandType = CommandType.Text;
            kk_connect.CommandText = "SELECT * FROM tbl_kamp";
            dr = kk_connect.ExecuteReader();

            while (dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr.GetString("kamp_ad");
                item.Value = dr.GetString("kamp_id");
                kamp_id.Items.Add(item);

            }
            con.Close();

            con.Open();
            MySqlCommand yk_connect = con.CreateCommand();
            yk_connect.CommandType = CommandType.Text;
            yk_connect.CommandText = "SELECT * FROM tbl_yardim_kurulus";
            dr1 = yk_connect.ExecuteReader();


            while (dr1.Read())
            {
                ComboboxItem item1 = new ComboboxItem();
                item1.Text = dr1.GetString("yk_ad");
                item1.Value = dr1.GetString("yk_id");
                yk_id.Items.Add(item1);

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

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti_tablosu formkapa = new baglanti_tablosu();
            formkapa.Close();
            tablolar_ekleme frm = new tablolar_ekleme();
            frm.Show();
            this.Hide();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
