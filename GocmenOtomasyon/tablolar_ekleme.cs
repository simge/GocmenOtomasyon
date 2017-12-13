using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GocmenOtomasyon
{
    public partial class tablolar_ekleme : Form
    {
        

        public tablolar_ekleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle_forms form1 = new ekle_forms();
            form1.Show();
            this.Hide();
        }
    }
}
