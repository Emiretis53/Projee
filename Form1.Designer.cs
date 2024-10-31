namespace Projee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nereden = new Label();
            nereye = new Label();
            combonereye = new ComboBox();
            combonereden = new ComboBox();
            otobakb = new Button();
            tarih = new Label();
            tarihsec = new DateTimePicker();
            admingirisb = new Button();
            ımageList1 = new ImageList(components);
            biletiptalb = new Button();
            ımageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nereden
            // 
            nereden.AutoSize = true;
            nereden.BackColor = Color.Transparent;
            nereden.Location = new Point(28, 29);
            nereden.Name = "nereden";
            nereden.Size = new Size(61, 15);
            nereden.TabIndex = 0;
            nereden.Text = "NEREDEN ";
            // 
            // nereye
            // 
            nereye.AutoSize = true;
            nereye.BackColor = Color.Transparent;
            nereye.Location = new Point(28, 82);
            nereye.Name = "nereye";
            nereye.Size = new Size(48, 15);
            nereye.TabIndex = 1;
            nereye.Text = "NEREYE";
            // 
            // combonereye
            // 
            combonereye.FormattingEnabled = true;
            combonereye.Items.AddRange(new object[] { "Adana\t", "Adıyaman\t\t\t", "Afyon\t\t", "Ağrı\t\t", "Amasya\t\t", "Ankara\t", "Antalya", "Artvin\t\t", "Aydın\t", "Balıkesir", "Bilecik\t", "Bingöl\t", "Bitlis\t", "Bolu\t", "Burdur\t", "Bursa\t", "Çanakkale\t", "Çankırı\t", "Çorum\t", "Denizli\t", "Diyarbakır\t", "Edirne", "Elazığ\t", "Erzincan\t", "Erzurum\t", "Eskişehir\t", "Gaziantep\t", "Giresun\t", "Gümüşhane\t", "Hakkari\t", "Hatay\t", "Isparta\t", "Mersin\t", "İstanbul\t", "İzmir\t", "Kars\t", "Kastamonu", "Kayseri\t", "Kırklareli\t", "Kırşehir\t", "Kocaeli\t", "Konya\t", "Kütahya\t", "Malatya\t", "Manisa\t", "Kahramanmaraş\t", "Mardin\t", "Muğla\t", "Muş\t", "Nevşehir\t", "Niğde\t", "Ordu\t", "Rize\t", "Sakarya\t", "Samsun\t", "Siirt\t", "Sinop\t", "Sivas\t", "Tekirdağ\t", "Tokat\t", "Trabzon\t", "Tunceli\t", "Şanlıurfa\t", "Uşak\t", "Van", "Yozgat\t", "Zonguldak\t", "Aksaray\t", "Bayburt\t", "Karaman\t", "Kırıkkale\t", "Batman\t", "Şırnak\t", "Bartın\t", "Ardahan\t", "Iğdır\t", "Yalova\t", "Karabük\t", "Kilis\t", "Osmaniye\t\t", "Düzce\t" });
            combonereye.Location = new Point(28, 99);
            combonereye.Margin = new Padding(3, 2, 3, 2);
            combonereye.Name = "combonereye";
            combonereye.Size = new Size(171, 23);
            combonereye.TabIndex = 2;
            // 
            // combonereden
            // 
            combonereden.FormattingEnabled = true;
            combonereden.Items.AddRange(new object[] { "Adana\t", "Adıyaman\t\t\t", "Afyon\t\t", "Ağrı\t\t", "Amasya\t\t", "Ankara\t", "Antalya", "Artvin\t\t", "Aydın\t", "Balıkesir", "Bilecik\t", "Bingöl\t", "Bitlis\t", "Bolu\t", "Burdur\t", "Bursa\t", "Çanakkale\t", "Çankırı\t", "Çorum\t", "Denizli\t", "Diyarbakır\t", "Edirne", "Elazığ\t", "Erzincan\t", "Erzurum\t", "Eskişehir\t", "Gaziantep\t", "Giresun\t", "Gümüşhane\t", "Hakkari\t", "Hatay\t", "Isparta\t", "Mersin\t", "İstanbul\t", "İzmir\t", "Kars\t", "Kastamonu", "Kayseri\t", "Kırklareli\t", "Kırşehir\t", "Kocaeli\t", "Konya\t", "Kütahya\t", "Malatya\t", "Manisa\t", "Kahramanmaraş\t", "Mardin\t", "Muğla\t", "Muş\t", "Nevşehir\t", "Niğde\t", "Ordu\t", "Rize\t", "Sakarya\t", "Samsun\t", "Siirt\t", "Sinop\t", "Sivas\t", "Tekirdağ\t", "Tokat\t", "Trabzon\t", "Tunceli\t", "Şanlıurfa\t", "Uşak\t", "Van", "Yozgat\t", "Zonguldak\t", "Aksaray\t", "Bayburt\t", "Karaman\t", "Kırıkkale\t", "Batman\t", "Şırnak\t", "Bartın\t", "Ardahan\t", "Iğdır\t", "Yalova\t", "Karabük\t", "Kilis\t", "Osmaniye\t\t", "Düzce\t" });
            combonereden.Location = new Point(28, 46);
            combonereden.Margin = new Padding(3, 2, 3, 2);
            combonereden.Name = "combonereden";
            combonereden.Size = new Size(171, 23);
            combonereden.TabIndex = 3;
            combonereden.SelectedIndexChanged += combonereden_SelectedIndexChanged;
            // 
            // otobakb
            // 
            otobakb.Location = new Point(239, 168);
            otobakb.Margin = new Padding(3, 2, 3, 2);
            otobakb.Name = "otobakb";
            otobakb.Size = new Size(171, 23);
            otobakb.TabIndex = 4;
            otobakb.Text = "OTOBÜS BAK";
            otobakb.UseVisualStyleBackColor = true;
            otobakb.Click += otobakb_Click;
            // 
            // tarih
            // 
            tarih.AutoSize = true;
            tarih.Location = new Point(28, 142);
            tarih.Name = "tarih";
            tarih.Size = new Size(40, 15);
            tarih.TabIndex = 5;
            tarih.Text = "TARİH";
            // 
            // tarihsec
            // 
            tarihsec.Location = new Point(28, 168);
            tarihsec.Margin = new Padding(3, 2, 3, 2);
            tarihsec.Name = "tarihsec";
            tarihsec.Size = new Size(171, 23);
            tarihsec.TabIndex = 6;
            // 
            // admingirisb
            // 
            admingirisb.ImageAlign = ContentAlignment.MiddleLeft;
            admingirisb.ImageKey = "360_F_475009987_zwsk4c77x3cTpcI3W1C1LU4pOSyPKaqi.jpg";
            admingirisb.ImageList = ımageList1;
            admingirisb.Location = new Point(454, 472);
            admingirisb.Margin = new Padding(3, 2, 3, 2);
            admingirisb.Name = "admingirisb";
            admingirisb.Size = new Size(138, 39);
            admingirisb.TabIndex = 7;
            admingirisb.Text = "ADMİN GİRİŞ";
            admingirisb.TextAlign = ContentAlignment.MiddleRight;
            admingirisb.UseVisualStyleBackColor = true;
            admingirisb.Click += admingirisb_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "360_F_475009987_zwsk4c77x3cTpcI3W1C1LU4pOSyPKaqi.jpg");
            ımageList1.Images.SetKeyName(1, "png-transparent-cancel-cercle-close-delete-dismiss-remove-web-ui-color-icon-thumbnail.png");
            // 
            // biletiptalb
            // 
            biletiptalb.BackColor = Color.Transparent;
            biletiptalb.ImageAlign = ContentAlignment.MiddleLeft;
            biletiptalb.ImageKey = "png-transparent-cancel-cercle-close-delete-dismiss-remove-web-ui-color-icon-thumbnail.png";
            biletiptalb.ImageList = ımageList2;
            biletiptalb.Location = new Point(454, 515);
            biletiptalb.Margin = new Padding(3, 2, 3, 2);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(138, 39);
            biletiptalb.TabIndex = 8;
            biletiptalb.Text = "BİLET İPTAL";
            biletiptalb.TextAlign = ContentAlignment.MiddleRight;
            biletiptalb.UseVisualStyleBackColor = false;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "png-transparent-cancel-cercle-close-delete-dismiss-remove-web-ui-color-icon-thumbnail.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.d209cfe457e410d808e0b9bd2787b09b;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.InitialImage = Properties.Resources._7ef24db3928b30fd17586d85d5c1e912;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 565);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 565);
            Controls.Add(biletiptalb);
            Controls.Add(admingirisb);
            Controls.Add(tarihsec);
            Controls.Add(tarih);
            Controls.Add(otobakb);
            Controls.Add(combonereden);
            Controls.Add(combonereye);
            Controls.Add(nereye);
            Controls.Add(nereden);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "TARİH SEÇİMİ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nereden;
        private Label nereye;
        private ComboBox combonereye;
        private ComboBox combonereden;
        private Label tarih;
        private DateTimePicker tarihsec;
        private Button admingirisb;
        private ImageList ımageList1;
        private Button biletiptalb;
        private ImageList ımageList2;
        private PictureBox pictureBox1;
        public Button otobakb;
    }
}
