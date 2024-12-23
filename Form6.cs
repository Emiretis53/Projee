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
    public partial class Form6 : Form
    {
        Musteribilgi musteri_bilgi = new Musteribilgi();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from yolcu_bilgi";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ygostermedata.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = $"delete from yolcu_bilgi where y_tc ='{yolcutc.Text}'";
            MySqlCommand cmd = new MySqlCommand(komut, connect);
            connect.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            connect.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from yolcu_bilgi";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ygostermedata.DataSource = dt;
        }

        private void idlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
