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
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;

        public goc_ekle()
        {
            InitializeComponent();
        }

        private void ekleme_button_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into tbl_goc(goc_tur,goc_trh)values('" + goc_tur.Text + "','" + goc_trh.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

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


    }
}
