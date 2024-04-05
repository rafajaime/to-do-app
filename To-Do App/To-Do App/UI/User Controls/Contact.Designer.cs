namespace To_Do_App
{
    partial class Contact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            lblTitulo = new Label();
            panelLinkedIn = new Panel();
            linkLinkedIn = new LinkLabel();
            pictureBox1 = new PictureBox();
            panelGmail = new Panel();
            linkGmail = new LinkLabel();
            pictureBox2 = new PictureBox();
            panelGithub = new Panel();
            linkGithub = new LinkLabel();
            pictureBox3 = new PictureBox();
            panelCelular = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox4 = new PictureBox();
            panelLinkedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelGithub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelCelular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitulo.Location = new Point(7, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(79, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Contacto";
            // 
            // panelLinkedIn
            // 
            panelLinkedIn.BackColor = Color.FromArgb(37, 42, 64);
            panelLinkedIn.Controls.Add(linkLinkedIn);
            panelLinkedIn.Controls.Add(pictureBox1);
            panelLinkedIn.Location = new Point(296, 153);
            panelLinkedIn.Name = "panelLinkedIn";
            panelLinkedIn.Size = new Size(227, 51);
            panelLinkedIn.TabIndex = 1;
            // 
            // linkLinkedIn
            // 
            linkLinkedIn.AutoSize = true;
            linkLinkedIn.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            linkLinkedIn.LinkColor = Color.FromArgb(0, 126, 249);
            linkLinkedIn.Location = new Point(78, 18);
            linkLinkedIn.Name = "linkLinkedIn";
            linkLinkedIn.Size = new Size(68, 13);
            linkLinkedIn.TabIndex = 1;
            linkLinkedIn.TabStop = true;
            linkLinkedIn.Text = "rafael-jaime";
            linkLinkedIn.LinkClicked += linkLinkedIn_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelGmail
            // 
            panelGmail.BackColor = Color.FromArgb(37, 42, 64);
            panelGmail.Controls.Add(linkGmail);
            panelGmail.Controls.Add(pictureBox2);
            panelGmail.Location = new Point(53, 153);
            panelGmail.Name = "panelGmail";
            panelGmail.Size = new Size(227, 51);
            panelGmail.TabIndex = 2;
            // 
            // linkGmail
            // 
            linkGmail.AutoSize = true;
            linkGmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            linkGmail.LinkColor = Color.FromArgb(0, 126, 249);
            linkGmail.Location = new Point(80, 18);
            linkGmail.Name = "linkGmail";
            linkGmail.Size = new Size(146, 13);
            linkGmail.TabIndex = 1;
            linkGmail.TabStop = true;
            linkGmail.Text = "jaimerafael.pp@gmail.com";
            linkGmail.LinkClicked += linkGmail_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelGithub
            // 
            panelGithub.BackColor = Color.FromArgb(37, 42, 64);
            panelGithub.Controls.Add(linkGithub);
            panelGithub.Controls.Add(pictureBox3);
            panelGithub.Location = new Point(296, 96);
            panelGithub.Name = "panelGithub";
            panelGithub.Size = new Size(227, 51);
            panelGithub.TabIndex = 3;
            // 
            // linkGithub
            // 
            linkGithub.AutoSize = true;
            linkGithub.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            linkGithub.LinkColor = Color.FromArgb(0, 126, 249);
            linkGithub.Location = new Point(78, 19);
            linkGithub.Name = "linkGithub";
            linkGithub.Size = new Size(55, 13);
            linkGithub.TabIndex = 1;
            linkGithub.TabStop = true;
            linkGithub.Text = "rafajaime";
            linkGithub.LinkClicked += linkGithub_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panelCelular
            // 
            panelCelular.BackColor = Color.FromArgb(37, 42, 64);
            panelCelular.Controls.Add(linkLabel1);
            panelCelular.Controls.Add(pictureBox4);
            panelCelular.Location = new Point(53, 96);
            panelCelular.Name = "panelCelular";
            panelCelular.Size = new Size(227, 51);
            panelCelular.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.FromArgb(0, 126, 249);
            linkLabel1.Location = new Point(80, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 13);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "+54 11-6220-3988";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            Controls.Add(panelCelular);
            Controls.Add(panelGithub);
            Controls.Add(panelGmail);
            Controls.Add(panelLinkedIn);
            Controls.Add(lblTitulo);
            Name = "Contact";
            Size = new Size(583, 627);
            Load += Contact_Load;
            VisibleChanged += Contact_VisibleChanged;
            panelLinkedIn.ResumeLayout(false);
            panelLinkedIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGmail.ResumeLayout(false);
            panelGmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelGithub.ResumeLayout(false);
            panelGithub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelCelular.ResumeLayout(false);
            panelCelular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private LinkLabel linkLinkedIn;
        private LinkLabel linkGmail;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkGithub;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox4;
        public Panel panelLinkedIn;
        public Panel panelGmail;
        public Panel panelGithub;
        public Panel panelCelular;
    }
}
