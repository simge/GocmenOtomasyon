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
    public partial class ulke_ekle_form : Form
        
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;
        public ulke_ekle_form()
        {
            InitializeComponent();
        }

        private void ulkebttn_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into tbl_gocmen_ulkesi(ulke_ad,ulke_uyruk)values('" + ulkead.Text + "','" + ulkeuyruk.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void ulkeuyruk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
