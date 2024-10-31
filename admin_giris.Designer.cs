namespace Projee
{
    partial class admin_giris
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
            adminkullanıcıadılabel = new Label();
            adminsifrelabel = new Label();
            admingirisbuton = new Button();
            adminkaditext = new TextBox();
            adminsifretext = new TextBox();
            SuspendLayout();
            // 
            // adminkullanıcıadılabel
            // 
            adminkullanıcıadılabel.AutoSize = true;
            adminkullanıcıadılabel.Location = new Point(37, 72);
            adminkullanıcıadılabel.Name = "adminkullanıcıadılabel";
            adminkullanıcıadılabel.Size = new Size(82, 19);
            adminkullanıcıadılabel.TabIndex = 0;
            adminkullanıcıadılabel.Text = "Kullanıcı Adı";
            // 
            // adminsifrelabel
            // 
            adminsifrelabel.AutoSize = true;
            adminsifrelabel.Location = new Point(84, 131);
            adminsifrelabel.Name = "adminsifrelabel";
            adminsifrelabel.Size = new Size(35, 19);
            adminsifrelabel.TabIndex = 1;
            adminsifrelabel.Text = "Şifre";
            // 
            // admingirisbuton
            // 
            admingirisbuton.Location = new Point(125, 192);
            admingirisbuton.Name = "admingirisbuton";
            admingirisbuton.Size = new Size(152, 42);
            admingirisbuton.TabIndex = 2;
            admingirisbuton.Text = "GİRİŞ";
            admingirisbuton.UseVisualStyleBackColor = true;
            admingirisbuton.Click += admingirisbuton_Click;
            // 
            // adminkaditext
            // 
            adminkaditext.Location = new Point(125, 69);
            adminkaditext.Name = "adminkaditext";
            adminkaditext.Size = new Size(152, 26);
            adminkaditext.TabIndex = 3;
            // 
            // adminsifretext
            // 
            adminsifretext.Location = new Point(125, 124);
            adminsifretext.Name = "adminsifretext";
            adminsifretext.Size = new Size(152, 26);
            adminsifretext.TabIndex = 4;
            // 
            // admin_giris
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 367);
            Controls.Add(adminsifretext);
            Controls.Add(adminkaditext);
            Controls.Add(admingirisbuton);
            Controls.Add(adminsifrelabel);
            Controls.Add(adminkullanıcıadılabel);
            Name = "admin_giris";
            Text = "ADMİN GİRİŞİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminkullanıcıadılabel;
        private Label adminsifrelabel;
        private Button admingirisbuton;
        private TextBox adminkaditext;
        private TextBox adminsifretext;
    }
}