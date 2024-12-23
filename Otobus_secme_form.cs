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
    public partial class Otobus_secme_form : Form
    {
        public Otobus_secme_form()
        {
            InitializeComponent();
        }

        private void metrob_Click(object sender, EventArgs e)
        {
            Koltuksecme koltuksecme = new Koltuksecme();
            koltuksecme.Show();
            this.Hide();
        }

        private void rizesesb_Click(object sender, EventArgs e)
        {
            Koltuksecme koltuksecme = new Koltuksecme();
            koltuksecme.Show();
            this.Hide();
        }

        private void pamukkaleb_Click(object sender, EventArgs e)
        {
            Koltuksecme koltuksecme = new Koltuksecme();
            koltuksecme.Show();
            this.Hide();
        }

        private void kamilkocb_Click(object sender, EventArgs e)
        {
            Koltuksecme koltuksecme = new Koltuksecme();
            koltuksecme.Show();
            this.Hide();
        }

        private void aliosmanulusoyb_Click(object sender, EventArgs e)
        {
            Koltuksecme koltuksecme = new Koltuksecme();
            koltuksecme.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
