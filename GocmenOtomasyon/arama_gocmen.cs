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
        MySqlConnection con = DaoClass.GetMySqlConnection();
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public arama_gocmen()
        {
            InitializeComponent();
        }
        private void arama_gocmen_Load_1(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter(@"SELECT `gocmen_id`, `goc_id`, `ulke_id`, `sehir_id`, `kamp_id`, `meslek_id`, `gocmen_ad`, `gocmen_soyad`, `gocmen_yas`, `gocmen_cinsiyet`, `gocmen_egitim_duzeyi` FROM `tbl_gocmen`", con);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        
        public void searchData(string valueToSearch)
        {
            string query = "SELECT *FROM tbl_gocmen WHERE CONCAT( `gocmen_id`, `goc_id`, `ulke_id`, `sehir_id`, `kamp_id`, `meslek_id`, `gocmen_ad`, `gocmen_soyad`, `gocmen_yas`, `gocmen_cinsiyet`, `gocmen_egitim_duzeyi`) like'%"+valueToSearch+ "%' ";
            command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
        }
        private void don_btn_Click(object sender, EventArgs e)
        {
            arama_gocmen formkapa = new arama_gocmen();
            formkapa.Close();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
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
