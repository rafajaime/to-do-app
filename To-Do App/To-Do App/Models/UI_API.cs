using System.Runtime.InteropServices;
using To_Do_App.Data_Access_Obj;
using To_Do_App.UI.Forms;

namespace To_Do_App.Models
{
    public static class UI_API
    {
        [DllImport("user32.dll")]   //Mover borderless form
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam,
        int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture(); //Capturar release de LClick
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static void PermitirMoverForm(MouseEventArgs e, nint handle)        //Func para mover form
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //Hacer bordes de form circulares
        public static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        //UI MODE (DARK Y LIGHT MODES)
        public static string StaticUIMode = "default";
        //Colores dark
        public static Color DarkColorFondo = Color.FromArgb(41, 51, 73);
        public static Color DarkColorTexto = Color.FromName("WindowText");
        public static Color DarkColorTituloUCs = Color.FromArgb(158, 161, 176);
        public static Color DarkColorNotasYControles = Color.FromArgb(37, 42, 64);

        public static Color DarkColorFormPrincipal = Color.FromArgb(24, 30, 54);
        public static Color DarkColorTituloApp = Color.FromArgb(0, 159, 149);

        //Colores light paleta sueca
        public static Color LightColorFondo = Color.FromArgb(241, 238, 220);
        public static Color LightColorTexto = Color.FromName("WindowText");
        public static Color LightColorTituloUCs = Color.FromArgb(179, 200, 207);
        public static Color LightColorNotasYControles = Color.FromArgb(229, 221, 197);

        public static Color LightColorFormPrincipal = Color.FromArgb(190, 215, 220);
        public static Color LightColorTituloApp = Color.FromArgb(72, 84, 96);

        public static void ActivarUIMode(string UIMode) //UIMode puede ser "dark" o "light" (sin comillas)
        {
            StaticUIMode = UIMode;
            ClaseNotaDAO.ModificarSettings(StaticUIMode);
        }


        public static void NuevoFormNotification(string tipo, string mensaje)
        {
            FormNotification notification = new FormNotification(tipo, mensaje);
            notification.Show();
        }
    }
}
