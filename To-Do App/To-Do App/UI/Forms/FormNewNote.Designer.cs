namespace To_Do_App.UI.Forms
{
    partial class FormNewNote
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            btnPlus = new Button();
            panelMenu = new Panel();
            btnEmoji = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(218, 107);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(29, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "✕";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(183, 107);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(29, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "✓";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(41, 51, 73);
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Font = new Font("Segoe UI", 13F);
            txtTitulo.Location = new Point(12, 5);
            txtTitulo.MaxLength = 28;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(235, 24);
            txtTitulo.TabIndex = 1;
            txtTitulo.Text = "Titulo";
            txtTitulo.Click += txtTitulo_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(41, 51, 73);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Location = new Point(10, 33);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(235, 67);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.Text = "Nueva nota";
            txtDescripcion.Click += txtDescripcion_Click;
            // 
            // btnPlus
            // 
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 12F);
            btnPlus.Location = new Point(0, 0);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(28, 29);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnEmoji);
            panelMenu.Controls.Add(btnPlus);
            panelMenu.Location = new Point(12, 106);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(28, 33);
            panelMenu.TabIndex = 3;
            // 
            // btnEmoji
            // 
            btnEmoji.FlatAppearance.BorderSize = 0;
            btnEmoji.FlatStyle = FlatStyle.Flat;
            btnEmoji.Location = new Point(34, 1);
            btnEmoji.Name = "btnEmoji";
            btnEmoji.Size = new Size(28, 29);
            btnEmoji.TabIndex = 4;
            btnEmoji.Text = "😄";
            btnEmoji.UseVisualStyleBackColor = true;
            btnEmoji.Click += btnEmoji_Click;
            // 
            // FormNewNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            ClientSize = new Size(259, 142);
            Controls.Add(panelMenu);
            Controls.Add(txtDescripcion);
            Controls.Add(txtTitulo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNewNote";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewNote";
            Load += FormNewNote_Load;
            MouseDown += FormNewNote_MouseDown;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private Button btnPlus;
        private Panel panelMenu;
        private Button btnEmoji;
    }
}