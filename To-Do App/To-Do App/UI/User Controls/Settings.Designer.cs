namespace To_Do_App.UI.User_Controls
{
    partial class Settings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            lblTitulo = new Label();
            pnlDarkMode = new Panel();
            rndChckDarkMode = new Models.RoundCheckbox();
            imgListSettings = new ImageList(components);
            lblDarkMode = new Label();
            pnlDarkModeBg = new Panel();
            btnUbicacionArchivo = new Button();
            pnlUbicacionArchivo = new Panel();
            pnlUbicacionArchivoBg = new Panel();
            pnlDarkMode.SuspendLayout();
            pnlUbicacionArchivo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitulo.Location = new Point(7, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(81, 21);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Opciones";
            // 
            // pnlDarkMode
            // 
            pnlDarkMode.BackColor = Color.FromArgb(37, 42, 64);
            pnlDarkMode.Controls.Add(rndChckDarkMode);
            pnlDarkMode.Controls.Add(lblDarkMode);
            pnlDarkMode.Location = new Point(20, 88);
            pnlDarkMode.Name = "pnlDarkMode";
            pnlDarkMode.Size = new Size(544, 60);
            pnlDarkMode.TabIndex = 3;
            // 
            // rndChckDarkMode
            // 
            rndChckDarkMode.Appearance = Appearance.Button;
            rndChckDarkMode.BackColor = Color.FromArgb(41, 51, 73);
            rndChckDarkMode.BackgroundImageLayout = ImageLayout.Zoom;
            rndChckDarkMode.Checked = true;
            rndChckDarkMode.CheckState = CheckState.Checked;
            rndChckDarkMode.FlatAppearance.BorderSize = 0;
            rndChckDarkMode.FlatAppearance.CheckedBackColor = Color.FromArgb(41, 51, 73);
            rndChckDarkMode.FlatStyle = FlatStyle.Flat;
            rndChckDarkMode.ImageIndex = 0;
            rndChckDarkMode.ImageList = imgListSettings;
            rndChckDarkMode.Location = new Point(492, 14);
            rndChckDarkMode.Name = "rndChckDarkMode";
            rndChckDarkMode.Size = new Size(36, 30);
            rndChckDarkMode.TabIndex = 6;
            rndChckDarkMode.UseVisualStyleBackColor = false;
            rndChckDarkMode.CheckStateChanged += rndChckDarkMode_CheckStateChanged;
            // 
            // imgListSettings
            // 
            imgListSettings.ColorDepth = ColorDepth.Depth32Bit;
            imgListSettings.ImageStream = (ImageListStreamer)resources.GetObject("imgListSettings.ImageStream");
            imgListSettings.TransparentColor = Color.Transparent;
            imgListSettings.Images.SetKeyName(0, "checksettings.png");
            // 
            // lblDarkMode
            // 
            lblDarkMode.AutoSize = true;
            lblDarkMode.Location = new Point(13, 21);
            lblDarkMode.Name = "lblDarkMode";
            lblDarkMode.Size = new Size(78, 15);
            lblDarkMode.TabIndex = 4;
            lblDarkMode.Text = "Modo oscuro";
            // 
            // pnlDarkModeBg
            // 
            pnlDarkModeBg.BackColor = Color.Black;
            pnlDarkModeBg.Location = new Point(19, 87);
            pnlDarkModeBg.Name = "pnlDarkModeBg";
            pnlDarkModeBg.Size = new Size(546, 62);
            pnlDarkModeBg.TabIndex = 4;
            // 
            // btnUbicacionArchivo
            // 
            btnUbicacionArchivo.FlatAppearance.BorderSize = 0;
            btnUbicacionArchivo.FlatStyle = FlatStyle.Flat;
            btnUbicacionArchivo.Location = new Point(7, 7);
            btnUbicacionArchivo.Name = "btnUbicacionArchivo";
            btnUbicacionArchivo.Size = new Size(152, 23);
            btnUbicacionArchivo.TabIndex = 5;
            btnUbicacionArchivo.Text = "Abrir ubicacion de notas";
            btnUbicacionArchivo.UseVisualStyleBackColor = true;
            btnUbicacionArchivo.Click += btnUbicacionArchivo_Click;
            // 
            // pnlUbicacionArchivo
            // 
            pnlUbicacionArchivo.BackColor = Color.FromArgb(37, 42, 64);
            pnlUbicacionArchivo.Controls.Add(btnUbicacionArchivo);
            pnlUbicacionArchivo.Location = new Point(411, 584);
            pnlUbicacionArchivo.Name = "pnlUbicacionArchivo";
            pnlUbicacionArchivo.Size = new Size(169, 40);
            pnlUbicacionArchivo.TabIndex = 5;
            // 
            // pnlUbicacionArchivoBg
            // 
            pnlUbicacionArchivoBg.BackColor = Color.Black;
            pnlUbicacionArchivoBg.Location = new Point(410, 583);
            pnlUbicacionArchivoBg.Name = "pnlUbicacionArchivoBg";
            pnlUbicacionArchivoBg.Size = new Size(171, 42);
            pnlUbicacionArchivoBg.TabIndex = 6;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            Controls.Add(pnlUbicacionArchivo);
            Controls.Add(pnlUbicacionArchivoBg);
            Controls.Add(pnlDarkMode);
            Controls.Add(pnlDarkModeBg);
            Controls.Add(lblTitulo);
            Name = "Settings";
            Size = new Size(583, 627);
            Load += Settings_Load;
            VisibleChanged += Settings_VisibleChanged;
            pnlDarkMode.ResumeLayout(false);
            pnlDarkMode.PerformLayout();
            pnlUbicacionArchivo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Models.RoundCheckbox rndChckDarkMode;
        private Panel pnlDarkModeBg;
        private Button btnUbicacionArchivo;
        private Panel pnlUbicacionArchivo;
        private Panel pnlUbicacionArchivoBg;
        private ImageList imgListSettings;
        public Label lblTitulo;
        public Panel pnlDarkMode;
        public Label lblDarkMode;
    }
}
