namespace Projee
{
    partial class Form6
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
            ygostermedata = new DataGridView();
            ylistelabel = new Label();
            biletiptalb = new Button();
            koltuktext = new TextBox();
            idlabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ygostermedata).BeginInit();
            SuspendLayout();
            // 
            // ygostermedata
            // 
            ygostermedata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ygostermedata.Location = new Point(32, 83);
            ygostermedata.Name = "ygostermedata";
            ygostermedata.Size = new Size(856, 374);
            ygostermedata.TabIndex = 0;
            // 
            // ylistelabel
            // 
            ylistelabel.AutoSize = true;
            ylistelabel.Location = new Point(32, 65);
            ylistelabel.Name = "ylistelabel";
            ylistelabel.Size = new Size(85, 15);
            ylistelabel.TabIndex = 1;
            ylistelabel.Text = "YOLCU LİSTESİ";
            // 
            // biletiptalb
            // 
            biletiptalb.Location = new Point(726, 473);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(131, 23);
            biletiptalb.TabIndex = 2;
            biletiptalb.Text = "BİLETİ İPTAL ET";
            biletiptalb.UseVisualStyleBackColor = true;
            biletiptalb.Click += button1_Click;
            // 
            // koltuktext
            // 
            koltuktext.Location = new Point(595, 473);
            koltuktext.Name = "koltuktext";
            koltuktext.Size = new Size(100, 23);
            koltuktext.TabIndex = 3;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(519, 477);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(70, 15);
            idlabel.TabIndex = 4;
            idlabel.Text = "Bilet id girin";
            // 
            // button1
            // 
            button1.Location = new Point(813, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 523);
            Controls.Add(button1);
            Controls.Add(idlabel);
            Controls.Add(koltuktext);
            Controls.Add(biletiptalb);
            Controls.Add(ylistelabel);
            Controls.Add(ygostermedata);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)ygostermedata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ylistelabel;
        private Button biletiptalb;
        public DataGridView ygostermedata;
        private TextBox koltuktext;
        private Label idlabel;
        private Button button1;
    }
}