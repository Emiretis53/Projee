namespace Projee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otobakb_Click(object sender, EventArgs e)
        {
            Otobus_secme_form otosec = new Otobus_secme_form();
            otosec.Show();
            this.Hide();
        }

        private void admingirisb_Click(object sender, EventArgs e)
        {
            admin_giris admin_giris = new admin_giris();
            admin_giris.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void combonereye_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
        }

        private void combonereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void UpdateComboBoxAvailability()
        {
            
        }
    }
}
