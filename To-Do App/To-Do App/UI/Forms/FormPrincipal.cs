using System.Runtime.InteropServices;
using To_Do_App.Data_Access_Obj;
using To_Do_App.Models;

namespace To_Do_App
{
    public partial class FormPrincipal : Form
    {
        [DllImport("user32.dll")]   //Mover borderless form
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam,
            int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture(); //Capturar release de LClick
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void UIPanelNavegacion(Button boton)    //Mover ubicacion de panel de nav a botones
        {
            pnlNavegacion.Height = boton.Height;
            pnlNavegacion.Top = boton.Top;
            pnlNavegacion.Left = boton.Left;
            pnlNavegacion.Visible = true;
        }

        public FormPrincipal()
        {
            ClaseNotaDAO.InicializarDB();
            ClaseNotaDAO.ConseguirSettings();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn
                (UI_API.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UIPanelNavegacion(btnHome);
            MostrarUC(ucHome);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UIPanelNavegacion(btnSettings);
            MostrarUC(ucSettings);
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            UIPanelNavegacion(btnContacto);
            MostrarUC(ucContact);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void lblUINombre_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucDefault_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucDefault_lbl1_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucDefault_lbl2_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void ucContact_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucContact_panelCelular_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucContact_panelGithub_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucContact_panelGmail_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucContact_panelLinkedIn_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucHome_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucHome_flopNotas_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucHome_lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucSettings_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucSettings_lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucSettings_pnlDarkMode_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void ucSettings_lblDarkMode_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MostrarUC(UserControl controlAMostrar)
        {
            ucDefault.Hide();
            ucContact.Hide();
            ucHome.Hide();
            ucSettings.Hide();
            controlAMostrar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucDefault.Show();
            ucContact.Hide();
            ucHome.Hide();
            ucSettings.Hide();
            ucHome.lblTitulo.MouseDown += ucHome_lblTitulo_MouseDown!;
            ucHome.flopNotas.MouseDown += ucHome_flopNotas_MouseDown!;
            ucContact.panelCelular.MouseDown += ucContact_panelCelular_MouseDown!;
            ucContact.panelGithub.MouseDown += ucContact_panelGithub_MouseDown!;
            ucContact.panelGmail.MouseDown += ucContact_panelGmail_MouseDown!;
            ucContact.panelLinkedIn.MouseDown += ucContact_panelLinkedIn_MouseDown!;
            ucSettings.lblTitulo.MouseDown += ucSettings_lblTitulo_MouseDown!;
            ucSettings.pnlDarkMode.MouseDown += ucSettings_pnlDarkMode_MouseDown!;
            ucSettings.lblDarkMode.MouseDown += ucSettings_lblDarkMode_MouseDown!;
            ucDefault.lblTitulo.MouseDown += ucDefault_lbl1_MouseDown!;  //Puse el codigo aca ya que el codigo del designer se vuelve a auto-generar
            ucDefault.lblDesc.MouseDown += ucDefault_lbl2_MouseDown!;  //cada vez que haces un cambio en la form, lo que borra estas 2 lineas (permite
        }                                                             //mover UC Default manteniendo apretado en los labels)


        public void ActualizarUIMode()
        {
            if(UI_API.StaticUIMode == "dark")
            {
                btnCerrar.BackColor = UI_API.DarkColorFondo;
                btnMinimizar.BackColor = UI_API.DarkColorFondo;
                btnHome.BackColor = UI_API.DarkColorFormPrincipal;
                btnSettings.BackColor = UI_API.DarkColorFormPrincipal;
                btnContacto.BackColor = UI_API.DarkColorFormPrincipal;

                lblUINombre.ForeColor = UI_API.DarkColorTituloApp;
                panelMenu.BackColor = UI_API.DarkColorFormPrincipal;
            }
            else if(UI_API.StaticUIMode == "light")
            {
                btnCerrar.BackColor = UI_API.LightColorFondo;
                btnMinimizar.BackColor = UI_API.LightColorFondo;
                btnHome.BackColor = UI_API.LightColorFormPrincipal;
                btnSettings.BackColor = UI_API.LightColorFormPrincipal;
                btnContacto.BackColor = UI_API.LightColorFormPrincipal;

                lblUINombre.ForeColor = UI_API.LightColorTituloApp;
                panelMenu.BackColor = UI_API.LightColorFormPrincipal;
            }
        }

    }
}
