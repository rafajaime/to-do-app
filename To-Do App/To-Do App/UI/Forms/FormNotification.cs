using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_App.Models;
using To_Do_App.Properties;

//<a href="https://www.flaticon.com/free-icons/tick" title="tick icons">Tick icons created by Kiranshastry - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/close" title="close icons">Close icons created by Ilham Fitrotul Hayat - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/info" title="info icons">Info icons created by Freepik - Flaticon</a>


namespace To_Do_App.UI.Forms
{
    public partial class FormNotification : Form
    {
        int formNotifX;
        int formNotifY;
        public FormNotification(string tipo, string mensaje)
        {
            InitializeComponent();
            EvaluarTipoMensajeYUIMode(tipo, mensaje);
            Region = System.Drawing.Region.FromHrgn
            (UI_API.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            Posicionar();
        }
        private void FormNotification_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void lblTipo_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void lblMensaje_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void picTipo_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void pnlNotif_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void Posicionar()
        {
            int ScreenHeight = Screen.PrimaryScreen!.WorkingArea.Height;
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            formNotifY = ScreenHeight - this.Height * 14;
            formNotifX = ScreenWidth - this.Width - 15;

            this.Location = new Point(formNotifX, formNotifY);
        }
        private void EvaluarTipoMensajeYUIMode(string tipo, string mensaje)
        {
            if (UI_API.StaticUIMode == "dark")
            {
                this.BackColor = UI_API.DarkColorFondo;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                this.BackColor = UI_API.LightColorFondo;
            }

            switch (tipo)
            {
                case "EXITO":
                    lblTipo.Text = "EXITO";
                    lblMensaje.Text = mensaje;
                    picTipo.Image = Resources.notifcheck;
                    pnlNotif.BackColor = Color.FromArgb(22, 156, 22);
                    break;

                case "ERROR":
                    lblTipo.Text = "ERROR";
                    lblMensaje.Text = mensaje;
                    picTipo.Image = Resources.notifcross;
                    pnlNotif.BackColor = Color.FromArgb(156, 22, 22);
                    break;

                case "INFO":
                    lblTipo.Text = "INFO";
                    lblMensaje.Text = mensaje;
                    picTipo.Image = Resources.notifinfo;
                    pnlNotif.BackColor = Color.FromArgb(22, 123, 156);
                    break;
            }
        }

        private void timerMostrarNotif_Tick(object sender, EventArgs e)
        {
            formNotifY += 13;
            this.Location = new Point(formNotifX, formNotifY);
            if (formNotifY >= 41)
            {
                timerMostrarNotif.Stop();
                timerEsconderNotif.Start();
            }
        }
        int contadorHide = 200;
        private void timerEsconderNotif_Tick(object sender, EventArgs e)
        {
            contadorHide--;
            if (contadorHide <= 0)
            {
                formNotifY -= 1;
                this.Location = new Point(formNotifX, formNotifY -= 13);
                if (formNotifY < -31)
                {
                    timerEsconderNotif.Stop();
                    contadorHide = 200;
                    Close();
                }
            }
        }
    }
}
