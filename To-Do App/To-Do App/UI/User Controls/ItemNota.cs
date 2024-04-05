using To_Do_App.UI.Forms;
using To_Do_App.Models;
using To_Do_App.Data_Access_Obj;

namespace To_Do_App.UI.User_Controls
{
    public partial class ItemNota : UserControl
    {
        public ItemNota()
        {
            InitializeComponent();
            wasDoubleClicked = false;
            Region = System.Drawing.Region.FromHrgn
            (UI_API.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            CambiarUIModeUCItemNota();
        }

        private int? _id;
        private string? _titulo;
        private string? _descripcion;

        private void checkNota_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNota.Checked)
            {
                checkNota.Text = "✗";
                isChecked = true;
            }
            else
            {
                checkNota.Text = " ";
                isChecked = false;
            }
        }

        private void ItemNota_DoubleClick(object sender, EventArgs e)
        {
            EditarNota();
            wasDoubleClicked = true;
        }

        private void txtTitulo_DoubleClick(object sender, EventArgs e)
        {
            EditarNota();
            wasDoubleClicked = true;
        }

        private void txtDescripcion_DoubleClick(object sender, EventArgs e)
        {
            EditarNota();
            wasDoubleClicked = true;
        }
        private void EditarNota()
        {
            FormNewNote newNote = new FormNewNote(Id);
            newNote.ShowDialog();
        }
        private void markAsCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = contextIsCompleted.Items[0];

            if (wasCompleted == 1)
            {
                wasCompleted = 0;
                pictureCompletado.Visible = false;
                ClaseNotaDAO.ModificarEstaCompletado(Id, wasCompleted);
                item.Text = "Marcar como completado";
            }
            else if (wasCompleted == 0)
            {
                wasCompleted = 1;
                pictureCompletado.Visible = true;
                ClaseNotaDAO.ModificarEstaCompletado(Id, wasCompleted);
                item.Text = "Deshacer completado";
            }
        }

        private void ItemNota_VisibleChanged(object sender, EventArgs e)
        {
            CambiarUIModeUCItemNota();
        }

        private void CambiarUIModeUCItemNota()
        {
            if (UI_API.StaticUIMode == "dark")
            {
                this.BackColor = UI_API.DarkColorNotasYControles;
                txtTitulo.ForeColor = UI_API.DarkColorTexto;
                txtTitulo.BackColor = UI_API.DarkColorNotasYControles;
                txtDescripcion.ForeColor = UI_API.DarkColorTexto;
                txtDescripcion.BackColor = UI_API.DarkColorNotasYControles;
            }
            else if (UI_API.StaticUIMode == "light")
            {
                this.BackColor = UI_API.LightColorNotasYControles;
                txtTitulo.ForeColor = UI_API.LightColorTexto;
                txtTitulo.BackColor = UI_API.LightColorNotasYControles;
                txtDescripcion.ForeColor = UI_API.LightColorTexto;
                txtDescripcion.BackColor = UI_API.LightColorNotasYControles;
            }
            else
            {
                UI_API.NuevoFormNotification("ERROR", "UI MODE desconocido");
            }
        }

        public int wasCompleted { get; set; }
        public bool wasDoubleClicked { get; set; }
        public bool isChecked { get; set; }
        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string? Titulo
        {
            get { return _titulo; }
            set { _titulo = value; txtTitulo.Text = value; }
        }
        public string? Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; txtDescripcion.Text = value; }
        }
    }
}
