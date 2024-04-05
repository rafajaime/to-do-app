namespace To_Do_App.UI.User_Controls
{
    partial class Default
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
            lblTitulo = new Label();
            lblDesc = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(210, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(163, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido a mi app de notas";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(3, 62);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(151, 15);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Este es un texto de ejemplo";
            // 
            // Default
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            Controls.Add(lblDesc);
            Controls.Add(lblTitulo);
            Name = "Default";
            Size = new Size(583, 627);
            VisibleChanged += Default_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTitulo;
        public Label lblDesc;
    }
}
