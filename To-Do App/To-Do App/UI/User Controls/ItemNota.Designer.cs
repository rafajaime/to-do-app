namespace To_Do_App.UI.User_Controls
{
    partial class ItemNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemNota));
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            checkNota = new CheckBox();
            contextIsCompleted = new ContextMenuStrip(components);
            markAsCompleteToolStripMenuItem = new ToolStripMenuItem();
            pictureCompletado = new PictureBox();
            contextIsCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCompletado).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(37, 42, 64);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Location = new Point(22, 42);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(133, 97);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.Text = "asodkloadksopsakdpoasdp podkasopdk asopdksaopkdasopdksa dadasopkdsapodksapo";
            txtDescripcion.DoubleClick += txtDescripcion_DoubleClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(37, 42, 64);
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Font = new Font("Segoe UI", 15.75F);
            txtTitulo.ImeMode = ImeMode.Close;
            txtTitulo.Location = new Point(60, 8);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(56, 28);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Título";
            txtTitulo.DoubleClick += txtTitulo_DoubleClick;
            // 
            // checkNota
            // 
            checkNota.Appearance = Appearance.Button;
            checkNota.FlatStyle = FlatStyle.Flat;
            checkNota.Location = new Point(151, 3);
            checkNota.Name = "checkNota";
            checkNota.Size = new Size(24, 24);
            checkNota.TabIndex = 3;
            checkNota.Text = " ";
            checkNota.TextAlign = ContentAlignment.MiddleCenter;
            checkNota.UseVisualStyleBackColor = true;
            checkNota.CheckedChanged += checkNota_CheckedChanged;
            // 
            // contextIsCompleted
            // 
            contextIsCompleted.BackColor = SystemColors.Control;
            contextIsCompleted.Items.AddRange(new ToolStripItem[] { markAsCompleteToolStripMenuItem });
            contextIsCompleted.Name = "contextIsCompleted";
            contextIsCompleted.Size = new Size(213, 26);
            // 
            // markAsCompleteToolStripMenuItem
            // 
            markAsCompleteToolStripMenuItem.Name = "markAsCompleteToolStripMenuItem";
            markAsCompleteToolStripMenuItem.Size = new Size(212, 22);
            markAsCompleteToolStripMenuItem.Text = "Marcar como completado";
            markAsCompleteToolStripMenuItem.Click += markAsCompleteToolStripMenuItem_Click;
            // 
            // pictureCompletado
            // 
            pictureCompletado.Image = (Image)resources.GetObject("pictureCompletado.Image");
            pictureCompletado.Location = new Point(151, 123);
            pictureCompletado.Name = "pictureCompletado";
            pictureCompletado.Size = new Size(24, 24);
            pictureCompletado.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCompletado.TabIndex = 5;
            pictureCompletado.TabStop = false;
            pictureCompletado.Visible = false;
            // 
            // ItemNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ContextMenuStrip = contextIsCompleted;
            Controls.Add(pictureCompletado);
            Controls.Add(checkNota);
            Controls.Add(txtTitulo);
            Controls.Add(txtDescripcion);
            Name = "ItemNota";
            Size = new Size(178, 150);
            VisibleChanged += ItemNota_VisibleChanged;
            DoubleClick += ItemNota_DoubleClick;
            contextIsCompleted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureCompletado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDescripcion;
        private TextBox txtTitulo;
        private CheckBox checkNota;
        private ToolStripMenuItem markAsCompleteToolStripMenuItem;
        public PictureBox pictureCompletado;
        public ContextMenuStrip contextIsCompleted;
    }
}
