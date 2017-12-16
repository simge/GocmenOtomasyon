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
    public partial class arama_gocmen : Form

       
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=gocmenotomasyon");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public arama_gocmen()
        {
            InitializeComponent();
        }
        private void arama_gocmen_Load_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = gocmenotomasyon");
            adapter = new MySqlDataAdapter(@"SELECT `gocmen_id`, `goc_id`, `ulke_id`, `sehir_id`, `kamp_id`, `meslek_id`, `gocmen_ad`, `gocmen_soyad`, `gocmen_yas`, `gocmen_cinsiyet`, `gocmen_egitim_duzeyi` FROM `tbl_gocmen`", con);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        
        public void searchData(string valueToSearch)
        {
            string query = "select *from tbl_gocmen where CONCAT( `gocmen_id`, `goc_id`, `ulke_id`, `sehir_id`, `kamp_id`, `meslek_id`, `gocmen_ad`, `gocmen_soyad`, `gocmen_yas`, `gocmen_cinsiyet`, `gocmen_egitim_duzeyi`) like'%"+valueToSearch+ "%' ";
            command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            string valueToSearch = ara_txb.Text.ToString();
            searchData(valueToSearch);
            
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ara_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
