using To_Do_App.Data_Access_Obj;
using To_Do_App.Models;
using To_Do_App.UI.User_Controls;

namespace To_Do_App.UI.Forms
{
    public partial class FormNewNote : Form
    {
        private static int contadorTitulo = 0;
        private static int contadorDesc = 0;
        private static int contadorMenu = 0;
        private static int? Id = -1;
        private static string Emoji = "😄";
        public FormNewNote(int? idNota = -1)
        {
            InitializeComponent();
            CambiarUIModeNewNote();
            Region = System.Drawing.Region.FromHrgn
            (UI_API.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            Id = idNota;
            contadorMenu = 2;
        }

        private void FormNewNote_MouseDown(object sender, MouseEventArgs e)
        {
            UI_API.PermitirMoverForm(e, Handle);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTitulo_Click(object sender, EventArgs e)
        {
            if (Id == -1)    //Si la nota no existe (su ID es -1)
            {
                if (contadorTitulo < 1)
                {
                    txtTitulo.Clear();
                    contadorTitulo++;
                }
            }
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (Id == -1)
            {
                if (contadorDesc < 1)
                {
                    txtDescripcion.Clear();
                    contadorDesc++;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Length > 0)
            {
                if (Id != -1)    //Si la ID existe
                {
                    ClaseNotaDAO.ModificarNotaEnDB(txtTitulo.Text, txtDescripcion.Text, Id);
                    UI_API.NuevoFormNotification("EXITO", "Se modificó la nota");
                    Close();
                }
                else if (Id == -1)   //Si la ID no existe
                {
                    ClaseNotaDAO.InsertarNotaEnDB(txtTitulo.Text, txtDescripcion.Text);
                    UI_API.NuevoFormNotification("EXITO", "Se creó una nota");
                    Close();
                }
            }
            else if (txtTitulo.Text.Length < 1)
            {
                UI_API.NuevoFormNotification("ERROR", "Debe introducir un título");
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (contadorMenu % 2 == 0)
            {
                panelMenu.Size = new Size(67, 33);
            }
            else
            {
                panelMenu.Size = new Size(28, 33);
            }
            contadorMenu++;
        }

        private void FormNewNote_Load(object sender, EventArgs e)
        {
            contadorTitulo = 0; //Contadores para que solo se pueda borrar el texto con un click
            contadorDesc = 0;   //la primera vez que se abre la form.

            if (Id != -1)    // Si la nota existe, poner en los textboxs la info de la nota
            {
                ItemNota notaConseguida = ClaseNotaDAO.ConseguirTituloYDescripcion(Id);

                txtTitulo.Text = notaConseguida.Titulo;
                txtDescripcion.Text = notaConseguida.Descripcion;
            }
        }

        public void CambiarUIModeNewNote()
        {
            if (UI_API.StaticUIMode == "dark")
            {
                this.BackColor = UI_API.DarkColorFormPrincipal;
                txtTitulo.BackColor = UI_API.DarkColorFormPrincipal;
                txtDescripcion.BackColor = UI_API.DarkColorFormPrincipal;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                this.BackColor = UI_API.LightColorFormPrincipal;
                txtTitulo.BackColor = UI_API.LightColorFormPrincipal;
                txtDescripcion.BackColor = UI_API.LightColorFormPrincipal;
            }
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            if (Id == -1)
            {
                if (contadorDesc < 1)
                {
                    txtDescripcion.Clear();
                    txtDescripcion.AppendText(Emoji);
                    contadorDesc++;
                }
                else if(contadorDesc > 0)
                {
                    txtDescripcion.AppendText(Emoji);
                }
            }
            else if(Id != -1)
            {
                txtDescripcion.AppendText(Emoji);
            }
        }
    }
}
