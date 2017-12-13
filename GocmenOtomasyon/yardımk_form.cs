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
    public partial class yardımk_form : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;
        public yardımk_form()
        {
            InitializeComponent();
        }

        private void yarktext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ykbttn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into tbl_yardim_kurulus(yk_ad) values ('"+ yarktext.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
