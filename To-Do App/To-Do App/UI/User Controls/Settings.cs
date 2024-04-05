using System.Diagnostics;
using To_Do_App.Models;
using To_Do_App.Data_Access_Obj;

namespace To_Do_App.UI.User_Controls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            rndChckDebeEstarActivo();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            pnlDarkMode.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, pnlDarkMode.Width, pnlDarkMode.Height, 30, 30));
            pnlDarkModeBg.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, pnlDarkModeBg.Width, pnlDarkModeBg.Height, 30, 30));

            pnlUbicacionArchivo.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, pnlUbicacionArchivo.Width, pnlUbicacionArchivo.Height, 30, 30));
            pnlUbicacionArchivoBg.Region = Region.FromHrgn(UI_API.CreateRoundRectRgn
            (0, 0, pnlUbicacionArchivoBg.Width, pnlUbicacionArchivoBg.Height, 30, 30));
        }

        private void btnUbicacionArchivo_Click(object sender, EventArgs e)
        {
            string filePath = ClaseNotaDAO.documentsPath + ClaseNotaDAO.customPath;
            if (Directory.Exists(filePath))
            {
                Process.Start("explorer.exe", filePath);
                UI_API.NuevoFormNotification("INFO", "Se abrió el directorio.");
            }
            else
            {
                UI_API.NuevoFormNotification("ERROR", "El directorio no existe. Pruebe borrando la DB y reiniciando el programa.");
            }
        }

        private void rndChckDebeEstarActivo()
        {
            if(UI_API.StaticUIMode == "dark")
            {
                rndChckDarkMode.Checked = true;
            }
            else if(UI_API.StaticUIMode == "light")
            {
                rndChckDarkMode.Checked = false;
            }
        }

        private void rndChckDarkMode_CheckStateChanged(object sender, EventArgs e)
        {
            if (rndChckDarkMode.Checked)
            {
                rndChckDarkMode.ImageIndex = 0;
                UI_API.ActivarUIMode("dark");
                CambiarUIModeUCSettings();
                UI_API.NuevoFormNotification("INFO", "Se activó el modo oscuro");
            }
            else if (!rndChckDarkMode.Checked)
            {
                rndChckDarkMode.ImageIndex = -1;    //-1 es sin imagen
                UI_API.ActivarUIMode("light");
                CambiarUIModeUCSettings();
                UI_API.NuevoFormNotification("INFO", "Se activó el modo claro");
            }
        }

        private void Settings_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                CambiarUIModeUCSettings();
            }
        }

        private void CambiarUIModeUCSettings()
        {
            FormPrincipal? formPrincipal = this.ParentForm! as FormPrincipal;

            if (UI_API.StaticUIMode == "dark")
            {
                formPrincipal?.ActualizarUIMode();

                this.BackColor = UI_API.DarkColorFondo;
                lblTitulo.ForeColor = UI_API.DarkColorTituloUCs;
                pnlDarkMode.BackColor = UI_API.DarkColorNotasYControles;
                pnlUbicacionArchivo.BackColor = UI_API.DarkColorNotasYControles;
                rndChckDarkMode.BackColor = UI_API.DarkColorNotasYControles;
                lblDarkMode.ForeColor = UI_API.DarkColorTexto;
                btnUbicacionArchivo.ForeColor = UI_API.DarkColorTexto;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                formPrincipal?.ActualizarUIMode();

                this.BackColor = UI_API.LightColorFondo;
                lblTitulo.ForeColor = UI_API.LightColorTituloUCs;
                pnlDarkMode.BackColor = UI_API.LightColorNotasYControles;
                pnlUbicacionArchivo.BackColor = UI_API.LightColorNotasYControles;
                rndChckDarkMode.BackColor = UI_API.LightColorFondo;
                lblDarkMode.ForeColor = UI_API.LightColorTexto;
                btnUbicacionArchivo.ForeColor = UI_API.LightColorTexto;
            }
            else
            {
                UI_API.NuevoFormNotification("ERROR", "UI MODE desconocido");
            }
        }
    }
}
