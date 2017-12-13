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
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;
        public sehir_ekle()
        {
            InitializeComponent();
        }

        private void sehir_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void shrekle_bttn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into tbl_kaldigi_sehir(sehir_ad)values('" + sehir_tbox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
