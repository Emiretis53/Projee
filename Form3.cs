using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee
{
    public partial class admin : Form
    {
        Form6 ad = new Form6();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yolcu_kontrol ykontrol = new yolcu_kontrol();
            ykontrol.Show();

        }

        private void biletiptalb_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            
        }
    }
}
