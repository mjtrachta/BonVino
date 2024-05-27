using VinoApp.Endidades;
using VinoApp.Formularios.Bodegas;
using VinoApp.Servicios;

namespace VinoApp
{
    public partial class MainForm : Form
    {
        private BodegaServicio _bodegaServicio;

        public MainForm()
        {
            InitializeComponent();
            _bodegaServicio = new BodegaServicio();
            CargarBodegas();
        }

        private void CargarBodegas()
        {
            var bodegas = _bodegaServicio.ObtenerBodegas();
            // Código para cargar bodegas en un control, como DataGridView
            // dataGridViewBodegas.DataSource = bodegas; (ejemplo)
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            // Crear una instancia del formulario ModificarBodegas
            ModificarBodegas modificarBodegasForm = new ModificarBodegas();

            // Mostrar el formulario ModificarBodegas
            modificarBodegasForm.ShowDialog(); // Utiliza Show() si no quieres que el formulario sea modal
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}