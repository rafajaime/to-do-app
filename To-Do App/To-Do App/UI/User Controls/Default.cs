using To_Do_App.Models;

namespace To_Do_App.UI.User_Controls
{
    public partial class Default : UserControl
    {
        public Default()
        {
            InitializeComponent();
        }

        private void Default_VisibleChanged(object sender, EventArgs e)
        {
            CambiarUIModeUCDefault();
        }

        private void CambiarUIModeUCDefault()
        {
            if (UI_API.StaticUIMode == "dark")
            {
                this.BackColor = UI_API.DarkColorFondo;
                lblTitulo.ForeColor = UI_API.DarkColorTexto;
                lblDesc.ForeColor = UI_API.DarkColorTexto;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                this.BackColor = UI_API.LightColorFondo;
                lblTitulo.ForeColor = UI_API.LightColorTexto;
                lblDesc.ForeColor = UI_API.LightColorTexto;
            }
            else
            {
                UI_API.NuevoFormNotification("ERROR", "UI MODE desconocido");
            }
        }
    }
}
