using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projee
{
    public partial class Musteribilgi : Form
    {
        yolcu_kontrol yk = new yolcu_kontrol();                          
       
        public Musteribilgi()
        {
            InitializeComponent();

        }        
        private void yisimtext_TextChanged(object sender, EventArgs e)
        {
            string isim = yisimtext.Text;

        }

        private void ysatinal_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            MySqlCommand komut = new MySqlCommand($"insert into yolcu_bilgi(y_isim,y_soyisim,y_telefon,y_mail,y_tc,y_kredi) values('{yisimtext.Text}','{ysoyisimtext.Text}','{ytelefontext.Text}','{ymailtext.Text}','{ytctext.Text}','{ykreditext.Text}'); ",connect);
            connect.Open();
            komut.ExecuteNonQuery();
            connect.Close();                      
            MessageBox.Show("Bilet satın alınmıştır!");


        }

        private void yiptal_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Satın alma işlemini iptal etmek istiyor musunuz ?", "İptal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 yes = new Form1();
                yes.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void ysoyisimtext_TextChanged(object sender, EventArgs e)
        {
            string soyisim = ysoyisimtext.Text;
        }

        private void ytelefontext_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int telefon = ytelefontext.Text.Length;
        }

        private void ymailtext_TextChanged(object sender, EventArgs e)
        {
            string mail = ymailtext.Text;
        }

        private void ytctext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Musteribilgi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
