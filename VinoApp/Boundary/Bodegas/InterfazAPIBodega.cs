using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VinoApp.Endidades;

namespace VinoApp.Formularios.Bodegas
{
    public partial class InterfazAPIBodega : Form
    {
        private Bodega _bodega;


        public InterfazAPIBodega(Bodega bodega)
        {
            InitializeComponent();
            _bodega = bodega;
            labelNombreBodega.Text = bodega.Nombre; // Establece el texto de la etiqueta con el nombre de la bodega
            vinosDataGridView.AutoGenerateColumns = true; // Configura para que las columnas se generen automáticamente
            CargarVinos(); // Este método se encarga de cargar los vinos de la bodega en el DataGridView
        }

        /*
        private void CargarVinos()
        {
            vinosDataGridView.Rows.Clear();
            vinosDataGridView.Columns.Clear();

            // Definir las columnas del DataGridView
            vinosDataGridView.Columns.Add("Nombre", "Nombre");
            vinosDataGridView.Columns.Add("Aniada", "Añada");
            vinosDataGridView.Columns.Add("ImagenEtiqueta", "ImagenEtiqueta");
            vinosDataGridView.Columns.Add("NotaDeCataBodega", "NotaDeCataBodega");
            vinosDataGridView.Columns.Add("PrecioArs", "Precio (ARS)");
            vinosDataGridView.Columns.Add("Maridaje", "Maridaje");
            vinosDataGridView.Columns.Add("Varietal", "Varietal");

            // Agregar los vinos de la bodega al DataGridView
            foreach (var vino in _bodega.Vinos)
            {
                // Verificar si hay un maridaje asociado al vino
                string nombreMaridaje = vino.Maridaje != null && vino.Maridaje.Count > 0 ? vino.Maridaje[0].Nombre : string.Empty;

                // Verificar si hay un varietal asociado al vino
                string descripcionVarietal = vino.Varietal != null && vino.Varietal.Count > 0 ? vino.Varietal[0].Descripcion : string.Empty;

                // Agregar una fila al DataGridView con la información del vino
                vinosDataGridView.Rows.Add(
                    vino.Nombre,
                    vino.Aniada,
                    vino.ImagenEtiqueta,
                    vino.NotaDeCataBodega,
                    vino.PrecioArs,
                    nombreMaridaje,
                    descripcionVarietal
                );
            }
        }
        */

        private void CargarVinos()
        {
            // Limpiar las filas existentes
            vinosDataGridView.Rows.Clear();

            // Verificar si ya existen columnas en el DataGridView
            if (vinosDataGridView.Columns.Count == 0)
            {
                // Si no hay columnas, definir las columnas del DataGridView
                vinosDataGridView.Columns.Add("Nombre", "Nombre");
                vinosDataGridView.Columns.Add("Aniada", "Añada");
                vinosDataGridView.Columns.Add("ImagenEtiqueta", "ImagenEtiqueta");
                vinosDataGridView.Columns.Add("NotaDeCataBodega", "NotaDeCataBodega");
                vinosDataGridView.Columns.Add("PrecioArs", "Precio (ARS)");
                vinosDataGridView.Columns.Add("Maridaje", "Maridaje");
                vinosDataGridView.Columns.Add("Varietal", "Varietal");
            }

            // Agregar los vinos de la bodega al DataGridView
            foreach (var vino in _bodega.Vinos)
            {
                // Verificar si hay un maridaje asociado al vino
                string nombreMaridaje = vino.Maridaje != null && vino.Maridaje.Count > 0 ? vino.Maridaje[0].Nombre : string.Empty;

                // Verificar si hay un varietal asociado al vino
                string descripcionVarietal = vino.Varietal != null && vino.Varietal.Count > 0 ? vino.Varietal[0].Descripcion : string.Empty;

                // Agregar una fila al DataGridView con la información del vino
                vinosDataGridView.Rows.Add(
                    vino.Nombre,
                    vino.Aniada,
                    vino.ImagenEtiqueta,
                    vino.NotaDeCataBodega,
                    vino.PrecioArs,
                    nombreMaridaje,
                    descripcionVarietal
                );
            }
        }


        //Método 9
        public void obtenerActualizacionVino(Bodega bodega)
        {

            InterfazAPIBodega verBodegaForm = new InterfazAPIBodega(bodega);
            verBodegaForm.ShowDialog();
        }

        private void vinosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}