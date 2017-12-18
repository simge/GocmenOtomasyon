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
    public partial class kullanici_giris : Form
    {
        public kullanici_giris()
        {
            InitializeComponent();
        }

        MySqlConnection con = DaoClass.GetMySqlConnection();

        private void giris_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand komut = new MySqlCommand("SELECT *FROM kullanici WHERE kullanici_ad = '" + ad.Text + "' AND kullanici_passw = '" + passw.Text + "'",con);
            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            con.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                passw.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                passw.PasswordChar = '*';
            }
        }
        private void passw_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanici_giris_Load(object sender, EventArgs e)
        {

        }

        
    }
}
