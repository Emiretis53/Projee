using Azure.Core.GeoJson;
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
    public partial class Form2 : Form
    {
        Form8 fr = new Form8();
        public Form2()
        {
            InitializeComponent();
        }
        

        private void biletiptalb_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = $"delete from yolcu_bilgi where y_tc = '{tcgiriptal.Text}' ";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Biletiniz İptal İptal Edilmiştir.");
            
        }
    }
}
