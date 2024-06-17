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
            CargarVinos();
        }


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
            vinosDataGridView.Columns.Add("Bodega", "Bodega");

            // Agregar los vinos de la bodega al DataGridView
            foreach (var vino in _bodega.Vinos)
            {
                vinosDataGridView.Rows.Add(vino.Nombre, vino.Aniada, vino.ImagenEtiqueta, vino.NotaDeCataBodega, vino.PrecioArs, vino.Maridaje, vino.Varietal, vino.Bodega);
            }

        }








    }
}

