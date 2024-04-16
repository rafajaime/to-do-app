namespace To_Do_App.UI.Forms
{
    partial class FormNotification
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
            components = new System.ComponentModel.Container();
            pnlNotif = new Panel();
            picTipo = new PictureBox();
            lblTipo = new Label();
            lblMensaje = new Label();
            timerMostrarNotif = new System.Windows.Forms.Timer(components);
            timerEsconderNotif = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picTipo).BeginInit();
            SuspendLayout();
            // 
            // pnlNotif
            // 
            pnlNotif.BackColor = Color.Black;
            pnlNotif.Location = new Point(-1, -2);
            pnlNotif.Name = "pnlNotif";
            pnlNotif.Size = new Size(10, 84);
            pnlNotif.TabIndex = 0;
            pnlNotif.MouseDown += pnlNotif_MouseDown;
            // 
            // picTipo
            // 
            picTipo.Image = Properties.Resources.notifcheck;
            picTipo.Location = new Point(22, 12);
            picTipo.Name = "picTipo";
            picTipo.Size = new Size(37, 33);
            picTipo.SizeMode = PictureBoxSizeMode.Zoom;
            picTipo.TabIndex = 1;
            picTipo.TabStop = false;
            picTipo.MouseDown += picTipo_MouseDown;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTipo.Location = new Point(65, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            lblTipo.MouseDown += lblTipo_MouseDown;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMensaje.Location = new Point(70, 29);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(51, 15);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "Mensaje";
            lblMensaje.MouseDown += lblMensaje_MouseDown;
            // 
            // timerMostrarNotif
            // 
            timerMostrarNotif.Enabled = true;
            timerMostrarNotif.Interval = 10;
            timerMostrarNotif.Tick += timerMostrarNotif_Tick;
            // 
            // timerEsconderNotif
            // 
            timerEsconderNotif.Interval = 10;
            timerEsconderNotif.Tick += timerEsconderNotif_Tick;
            // 
            // FormNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(lblMensaje);
            Controls.Add(lblTipo);
            Controls.Add(picTipo);
            Controls.Add(pnlNotif);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNotification";
            ShowInTaskbar = false;
            Text = "FormNotification";
            TopMost = true;
            Load += FormNotification_Load;
            MouseDown += FormNotification_MouseDown;
            ((System.ComponentModel.ISupportInitialize)picTipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNotif;
        private PictureBox picTipo;
        private Label lblTipo;
        private Label lblMensaje;
        private System.Windows.Forms.Timer timerMostrarNotif;
        private System.Windows.Forms.Timer timerEsconderNotif;
    }
}