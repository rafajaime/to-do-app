namespace To_Do_App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelMenu = new Panel();
            pnlNavegacion = new Panel();
            btnContacto = new Button();
            imglBotones = new ImageList(components);
            btnSettings = new Button();
            btnHome = new Button();
            PanelMenuNotas = new Panel();
            lblUINombre = new Label();
            pictureBox1 = new PictureBox();
            ucSettings = new UI.User_Controls.Settings();
            ucHome = new UI.User_Controls.Home();
            ucContact = new Contact();
            ucDefault = new UI.User_Controls.Default();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            panelMenu.SuspendLayout();
            PanelMenuNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 30, 54);
            panelMenu.Controls.Add(pnlNavegacion);
            panelMenu.Controls.Add(btnContacto);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(PanelMenuNotas);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(110, 629);
            panelMenu.TabIndex = 0;
            panelMenu.MouseDown += panel1_MouseDown;
            // 
            // pnlNavegacion
            // 
            pnlNavegacion.BackColor = Color.FromArgb(0, 126, 249);
            pnlNavegacion.Location = new Point(0, 99);
            pnlNavegacion.Name = "pnlNavegacion";
            pnlNavegacion.Size = new Size(3, 100);
            pnlNavegacion.TabIndex = 1;
            pnlNavegacion.Visible = false;
            // 
            // btnContacto
            // 
            btnContacto.BackColor = Color.FromArgb(24, 30, 54);
            btnContacto.BackgroundImageLayout = ImageLayout.Zoom;
            btnContacto.FlatAppearance.BorderSize = 0;
            btnContacto.FlatStyle = FlatStyle.Flat;
            btnContacto.ImageIndex = 2;
            btnContacto.ImageList = imglBotones;
            btnContacto.Location = new Point(3, 527);
            btnContacto.Name = "btnContacto";
            btnContacto.Size = new Size(104, 100);
            btnContacto.TabIndex = 1;
            btnContacto.UseVisualStyleBackColor = false;
            btnContacto.Click += btnContacto_Click;
            // 
            // imglBotones
            // 
            imglBotones.ColorDepth = ColorDepth.Depth32Bit;
            imglBotones.ImageStream = (ImageListStreamer)resources.GetObject("imglBotones.ImageStream");
            imglBotones.TransparentColor = Color.Transparent;
            imglBotones.Images.SetKeyName(0, "home.png");
            imglBotones.Images.SetKeyName(1, "settings.png");
            imglBotones.Images.SetKeyName(2, "contact.png");
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ImageIndex = 1;
            btnSettings.ImageList = imglBotones;
            btnSettings.Location = new Point(3, 205);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(104, 100);
            btnSettings.TabIndex = 1;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ImageIndex = 0;
            btnHome.ImageList = imglBotones;
            btnHome.Location = new Point(3, 99);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(104, 100);
            btnHome.TabIndex = 1;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // PanelMenuNotas
            // 
            PanelMenuNotas.Controls.Add(lblUINombre);
            PanelMenuNotas.Controls.Add(pictureBox1);
            PanelMenuNotas.Location = new Point(0, 0);
            PanelMenuNotas.Name = "PanelMenuNotas";
            PanelMenuNotas.Size = new Size(110, 99);
            PanelMenuNotas.TabIndex = 0;
            PanelMenuNotas.MouseDown += panel2_MouseDown;
            // 
            // lblUINombre
            // 
            lblUINombre.AutoSize = true;
            lblUINombre.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUINombre.ForeColor = Color.FromArgb(0, 159, 149);
            lblUINombre.Location = new Point(28, 70);
            lblUINombre.Name = "lblUINombre";
            lblUINombre.Size = new Size(55, 21);
            lblUINombre.TabIndex = 1;
            lblUINombre.Text = "Notas";
            lblUINombre.MouseDown += lblUINombre_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // ucSettings
            // 
            ucSettings.BackColor = Color.FromArgb(41, 51, 73);
            ucSettings.Location = new Point(113, 0);
            ucSettings.Name = "ucSettings";
            ucSettings.Size = new Size(583, 627);
            ucSettings.TabIndex = 2;
            ucSettings.MouseDown += ucSettings_MouseDown;
            // 
            // ucHome
            // 
            ucHome.BackColor = Color.FromArgb(41, 51, 73);
            ucHome.Location = new Point(113, 0);
            ucHome.Name = "ucHome";
            ucHome.Size = new Size(583, 627);
            ucHome.TabIndex = 1;
            ucHome.MouseDown += ucHome_MouseDown;
            // 
            // ucContact
            // 
            ucContact.BackColor = Color.FromArgb(41, 51, 73);
            ucContact.Location = new Point(113, 0);
            ucContact.Name = "ucContact";
            ucContact.Size = new Size(583, 627);
            ucContact.TabIndex = 2;
            ucContact.MouseDown += ucContact_MouseDown;
            // 
            // ucDefault
            // 
            ucDefault.BackColor = Color.FromArgb(41, 51, 73);
            ucDefault.Location = new Point(113, 0);
            ucDefault.Name = "ucDefault";
            ucDefault.Size = new Size(583, 627);
            ucDefault.TabIndex = 3;
            ucDefault.MouseDown += ucDefault_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(41, 51, 73);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.Location = new Point(672, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "x";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(41, 51, 73);
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 10F);
            btnMinimizar.Location = new Point(642, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            ClientSize = new Size(698, 629);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(ucContact);
            Controls.Add(ucHome);
            Controls.Add(panelMenu);
            Controls.Add(ucSettings);
            Controls.Add(ucDefault);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panelMenu.ResumeLayout(false);
            PanelMenuNotas.ResumeLayout(false);
            PanelMenuNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel PanelMenuNotas;
        private PictureBox pictureBox1;
        private Label lblUINombre;
        private Button btnHome;
        private ImageList imglBotones;
        private Button btnContacto;
        private Button btnSettings;
        private Panel pnlNavegacion;
        private UI.User_Controls.Home ucHome;
        private Contact ucContact;
        private UI.User_Controls.Default ucDefault;
        private Button btnMinimizar;
        private UI.User_Controls.Settings ucSettings;
        private Button btnCerrar;
    }
}
