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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void soyad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            string sql;
            DaoSinifi db = new DaoSinifi();
            db.Db_connect();

            db.Update_values("gocmen_ad", ad.Text);
            db.Update_values("gocmen_soyad", soyad.Text);
            db.Update_values("gocmen_yas", yas.Text);
            db.Update_values("gocmen_cinsiyet", cinsiyet.Text);
            db.Update_values("gocmen_egitim_duzeyi",egitim_duzeyi.Text);
          
          sql = db.Sql_update("tbl_gocmen", "gocmen_id ='" + id.Text + "'");
            if (Convert.ToBoolean(db.Sql_query(sql)))
            {
                MessageBox.Show("Başarılı");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
