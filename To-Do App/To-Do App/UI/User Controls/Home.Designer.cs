namespace To_Do_App.UI.User_Controls
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lblTitulo = new Label();
            panel1 = new Panel();
            btnDeleteNote = new Models.RoundButton();
            imgListBotonMinus = new ImageList(components);
            btnNewNote = new Models.RoundButton();
            imgListBotonPlus = new ImageList(components);
            flopNotas = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitulo.Location = new Point(7, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(53, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Inicio";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteNote);
            panel1.Controls.Add(btnNewNote);
            panel1.Location = new Point(0, 527);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 100);
            panel1.TabIndex = 2;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteNote.FlatAppearance.BorderSize = 0;
            btnDeleteNote.FlatStyle = FlatStyle.Flat;
            btnDeleteNote.ImageIndex = 0;
            btnDeleteNote.ImageList = imgListBotonMinus;
            btnDeleteNote.Location = new Point(75, 21);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(71, 55);
            btnDeleteNote.TabIndex = 4;
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // imgListBotonMinus
            // 
            imgListBotonMinus.ColorDepth = ColorDepth.Depth32Bit;
            imgListBotonMinus.ImageStream = (ImageListStreamer)resources.GetObject("imgListBotonMinus.ImageStream");
            imgListBotonMinus.TransparentColor = Color.Transparent;
            imgListBotonMinus.Images.SetKeyName(0, "removenoteDark.png");
            imgListBotonMinus.Images.SetKeyName(1, "removenoteLight.png");
            // 
            // btnNewNote
            // 
            btnNewNote.BackgroundImageLayout = ImageLayout.Zoom;
            btnNewNote.FlatAppearance.BorderSize = 0;
            btnNewNote.FlatStyle = FlatStyle.Flat;
            btnNewNote.ImageIndex = 0;
            btnNewNote.ImageList = imgListBotonPlus;
            btnNewNote.Location = new Point(3, 21);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(71, 55);
            btnNewNote.TabIndex = 4;
            btnNewNote.UseVisualStyleBackColor = true;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // imgListBotonPlus
            // 
            imgListBotonPlus.ColorDepth = ColorDepth.Depth32Bit;
            imgListBotonPlus.ImageStream = (ImageListStreamer)resources.GetObject("imgListBotonPlus.ImageStream");
            imgListBotonPlus.TransparentColor = Color.Transparent;
            imgListBotonPlus.Images.SetKeyName(0, "addnoteDark.png");
            imgListBotonPlus.Images.SetKeyName(1, "addnoteLight.png");
            // 
            // flopNotas
            // 
            flopNotas.AutoScroll = true;
            flopNotas.Location = new Point(3, 44);
            flopNotas.Name = "flopNotas";
            flopNotas.Size = new Size(577, 477);
            flopNotas.TabIndex = 3;
            flopNotas.MouseEnter += flopNotas_MouseEnter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            Controls.Add(flopNotas);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Name = "Home";
            Size = new Size(583, 627);
            Load += Home_Load;
            VisibleChanged += Home_VisibleChanged;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        public FlowLayoutPanel flopNotas;
        private Models.RoundButton btnNewNote;
        private Models.RoundButton btnDeleteNote;
        private ImageList imgListBotonPlus;
        public Label lblTitulo;
        public ImageList imgListBotonMinus;
    }
}
