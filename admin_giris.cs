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
    public partial class admin_giris : Form
    {
        public admin_giris()
        {
            InitializeComponent();
        }

        private void admingirisbuton_Click(object sender, EventArgs e)
        {

            string adminkullaniciadi = "admin";
            int sifre = 12345;
            adminsifretext.Text = sifre.ToString();
            if (adminkullaniciadi == adminkaditext.Text && sifre == sifre)
            {
                MessageBox.Show("Admin girişi başarılı");
                admin admin_giris = new admin();
                admin_giris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış, giriş başarısız");
                this.Close();
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            
        }
    }
}
