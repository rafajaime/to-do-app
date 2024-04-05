using System.Diagnostics;
using To_Do_App.Models;

namespace To_Do_App
{
    public partial class Contact : UserControl
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "tel:+541162203988";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }
        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/rafajaime";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void linkGmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "mailto:jaimerafael.pp@gmail.com";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void linkLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/in/rafael-jaime/";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            panelCelular.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, panelCelular.Width, panelCelular.Height, 30, 30));

            panelGithub.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, panelCelular.Width, panelCelular.Height, 30, 30));

            panelGmail.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, panelCelular.Width, panelCelular.Height, 30, 30));

            panelLinkedIn.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, panelCelular.Width, panelCelular.Height, 30, 30));
        }

        private void Contact_VisibleChanged(object sender, EventArgs e)
        {
            CambiarUIModeUCContact();
        }
        private void CambiarUIModeUCContact()
        {
            if (UI_API.StaticUIMode == "dark")
            {
                this.BackColor = UI_API.DarkColorFondo;
                lblTitulo.ForeColor = UI_API.DarkColorTituloUCs;
                panelCelular.BackColor = UI_API.DarkColorNotasYControles;
                panelGithub.BackColor = UI_API.DarkColorNotasYControles;
                panelGmail.BackColor = UI_API.DarkColorNotasYControles;
                panelLinkedIn.BackColor = UI_API.DarkColorNotasYControles;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                this.BackColor = UI_API.LightColorFondo;
                lblTitulo.ForeColor = UI_API.LightColorTituloUCs;
                panelCelular.BackColor = UI_API.LightColorNotasYControles;
                panelGithub.BackColor = UI_API.LightColorNotasYControles;
                panelGmail.BackColor = UI_API.LightColorNotasYControles;
                panelLinkedIn.BackColor = UI_API.LightColorNotasYControles;
            }
            else
            {
                UI_API.NuevoFormNotification("ERROR", "UI MODE desconocido");
            }
        }
    }
}
