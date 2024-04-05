using To_Do_App.Data_Access_Obj;
using To_Do_App.Models;
using To_Do_App.UI.Forms;

namespace To_Do_App.UI.User_Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            CambiarUIModeUCHome();
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            FormNewNote form = new FormNewNote();
            form.ShowDialog();
            PopulateFlopNotas();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            PopulateFlopNotas();
        }

        public void PopulateFlopNotas()
        {
            flopNotas.Controls.Clear();
            List<ItemNota> listaDB = ClaseNotaDAO.ConseguirEntriesDB();

            foreach (ItemNota e in listaDB)
            {
                flopNotas.Controls.Add(e);
            }
        }

        private void flopNotas_MouseEnter(object sender, EventArgs e)
        {
            foreach (ItemNota nota in flopNotas.Controls)
            {
                if (nota.wasDoubleClicked)
                {
                    PopulateFlopNotas();    //Actualizar cada vez que se haya doble clickeado un item
                }

                ToolStripItem item = nota.contextIsCompleted.Items[0];  //Detectar cuales estan completados y hacer el checkmark visible en el UI
                if (nota.wasCompleted == 1)                             //Tambien ajustar texto del contextmenu acorde a si esta completado o no.
                {
                    nota.pictureCompletado.Visible = true;
                    item.Text = "Deshacer completado";
                }
                else if (nota.wasCompleted == 0)
                {
                    nota.pictureCompletado.Visible = false;
                    item.Text = "Marcar como completado";
                }
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            int contadorNotasBorradas = 0;
            bool wasAnyItemChecked = false;
            foreach (ItemNota item in flopNotas.Controls)
            {
                if (item.isChecked == true)
                {
                    ClaseNotaDAO.BorrarNotaEnDB(item.Id);
                    if(contadorNotasBorradas < 1)
                    {
                        UI_API.NuevoFormNotification("EXITO", "Se eliminó la nota");
                    }
                    else if(contadorNotasBorradas > 0)
                    {
                        UI_API.NuevoFormNotification("EXITO", "Se eliminaron las notas");
                    }    
                    contadorNotasBorradas++;
                    wasAnyItemChecked = true;
                }
            }

            if (!wasAnyItemChecked)
            {
                UI_API.NuevoFormNotification("ERROR", "Debe seleccionar al menos una nota");
            }
            PopulateFlopNotas();
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            CambiarUIModeUCHome();
        }
        private void CambiarUIModeUCHome()
        {
            FormPrincipal? formPrincipal = this.ParentForm! as FormPrincipal;

            if (UI_API.StaticUIMode == "dark")
            {
                formPrincipal?.ActualizarUIMode();
                this.BackColor = UI_API.DarkColorFondo;
                lblTitulo.ForeColor = UI_API.DarkColorTituloUCs;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                formPrincipal?.ActualizarUIMode();
                this.BackColor = UI_API.LightColorFondo;
                lblTitulo.ForeColor = UI_API.LightColorTituloUCs;
            }
            else
            {
                UI_API.NuevoFormNotification("ERROR", "UI MODE desconocido");
            }
        }
    }
}
