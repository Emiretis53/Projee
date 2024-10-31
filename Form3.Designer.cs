namespace Projee
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            biletiptalb = new Button();
            ykontrolb = new Button();
            otokontrolb = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // biletiptalb
            // 
            biletiptalb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            biletiptalb.Location = new Point(114, 62);
            biletiptalb.Margin = new Padding(3, 2, 3, 2);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(124, 36);
            biletiptalb.TabIndex = 0;
            biletiptalb.Text = "BİLET İPTAL";
            biletiptalb.UseVisualStyleBackColor = true;
            biletiptalb.Click += biletiptalb_Click;
            // 
            // ykontrolb
            // 
            ykontrolb.BackColor = Color.Transparent;
            ykontrolb.Location = new Point(114, 139);
            ykontrolb.Margin = new Padding(3, 2, 3, 2);
            ykontrolb.Name = "ykontrolb";
            ykontrolb.Size = new Size(124, 36);
            ykontrolb.TabIndex = 1;
            ykontrolb.Text = "YOLCU KONTROL";
            ykontrolb.UseVisualStyleBackColor = false;
            ykontrolb.Click += button2_Click;
            // 
            // otokontrolb
            // 
            otokontrolb.BackColor = Color.Transparent;
            otokontrolb.Location = new Point(114, 226);
            otokontrolb.Margin = new Padding(3, 2, 3, 2);
            otokontrolb.Name = "otokontrolb";
            otokontrolb.Size = new Size(124, 36);
            otokontrolb.TabIndex = 2;
            otokontrolb.Text = "OTOBÜS KONTROL";
            otokontrolb.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._360_F_475009987_zwsk4c77x3cTpcI3W1C1LU4pOSyPKaqi__1_;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.InitialImage = Properties.Resources._360_F_475009987_zwsk4c77x3cTpcI3W1C1LU4pOSyPKaqi__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 361);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 361);
            Controls.Add(otokontrolb);
            Controls.Add(ykontrolb);
            Controls.Add(biletiptalb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin";
            Text = "ADMİN PANEL";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button biletiptalb;
        private Button ykontrolb;
        private Button otokontrolb;
        private PictureBox pictureBox1;
    }
}