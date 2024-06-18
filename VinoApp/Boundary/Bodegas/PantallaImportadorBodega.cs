using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VinoApp.Endidades;
using VinoApp.Servicios;
using VinoApp.Modelos;

namespace VinoApp.Formularios.Bodegas
{
    public partial class PantallaImportadorBodega : Form
    {
        private GestorImportadorBodega gestor;
        private List<Bodega> _bodegas;
        private Bodega bodegaSeleccionada;



        //Método 2
        public void habilitarPantalla()
        {
            InitializeComponent();

        }

        public PantallaImportadorBodega(GestorImportadorBodega gestor)
        {
            habilitarPantalla();
            this.gestor = gestor;
        }

        private void PantallaImportadorBodega_Load(object sender, EventArgs e)
        {
            //Uso de Método 1
            _bodegas = gestor.OpcionImportarActualizacionVinos();
            mostrarBodegasParaActualizar();
        }

        //Método 6
        private void mostrarBodegasParaActualizar()
        {
            listViewBodegas.Items.Clear();

            foreach (var bodega in _bodegas)
            {
                ListViewItem item = new ListViewItem(bodega.getNombre());
                item.Tag = bodega;
                listViewBodegas.Items.Add(item);
            }
        }

        private void listViewBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBodegas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewBodegas.SelectedItems[0];
                Bodega bodegaSeleccionada = selectedItem.Tag as Bodega;
                if (bodegaSeleccionada != null)
                {
                    //Uso Método 7
                    gestor.tomarSeleccionBodega(bodegaSeleccionada);
                }
            }
        }


        //Método 24 (mostrar resumen vinos importados)
        public void mostrarResumenVinosImportados(Bodega bodega, List<Vino> vinosActualizados)
        {
            string mensaje = "Los vinos de la " + bodega.Nombre + " se han actualizado correctamente.\n\n";
            mensaje += "**Detalles de los vinos actualizados y creados:**\n";

            foreach (var vinoExistente in bodega.Vinos)
            {
                // Buscar el vino correspondiente en el JSON
                var nuevoVino = vinosActualizados.FirstOrDefault(v => v.Nombre == vinoExistente.Nombre);

                // Si se encuentra el vino correspondiente
                if (nuevoVino != null)
                {
                    // Mostrar los atributos actualizados del vino existente
                    string mensajeVino = "\n**Vino:** " + vinoExistente.Nombre + "\n";
                    mensajeVino += "  * **Nombre:** " + vinoExistente.Nombre + "\n";
                    mensajeVino += "  * **Imagen Etiqueta:** " + vinoExistente.ImagenEtiqueta + "\n";
                    mensajeVino += "  * **Nota De Cata Bodega:** " + vinoExistente.NotaDeCataBodega + "\n";
                    mensajeVino += "  * **Precio Ars:** " + vinoExistente.PrecioArs.ToString("C2") + "\n";

                    // Concatenar el mensaje del vino al mensaje principal
                    mensaje += mensajeVino;
                }
            }

            DialogResult resultado = MessageBox.Show(mensaje, "Actualización completada",
                                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar estado de la bodega
            if (resultado == DialogResult.OK)
            {
                bodega.FechaUltimaActualizacion = DateTime.Now;
            }
        }

    }
}

