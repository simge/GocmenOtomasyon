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
    public partial class kamp_form : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
        private MySqlDataReader dr;
        public kamp_form()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void kampbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            ComboboxItem sehiritem = (ComboboxItem)kamp_cbx.SelectedItem;
            string sehir_value = sehiritem.Value.ToString();

            cmd.CommandText = "insert into tbl_kamp(sehir_id,kamp_ad, kurul_trh) values ('" + Int32.Parse(sehir_value) + "','" + kampadi.Text + "','" + kamptrh.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void kamp_form_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand sehir_connect = con.CreateCommand();
            sehir_connect.CommandType = CommandType.Text;
            sehir_connect.CommandText = "select * from tbl_kaldigi_sehir";
            dr = sehir_connect.ExecuteReader();

            while (dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr.GetString("sehir_ad");
                item.Value = dr.GetString("sehir_id");
                kamp_cbx.Items.Add(item);

            }
            con.Close();
        }

        private void kamp_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

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


    }
}
