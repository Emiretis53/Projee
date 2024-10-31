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
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from yolcular";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ygostermedata.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = $"delete from yolcular where y_koltuk ='{koltuktext.Text}'";
            MySqlCommand cmd = new MySqlCommand(komut, connect);
            connect.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            connect.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from yolcular";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ygostermedata.DataSource = dt;
        }
    }
}
