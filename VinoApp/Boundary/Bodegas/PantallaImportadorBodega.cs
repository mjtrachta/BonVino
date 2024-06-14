using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VinoApp.Endidades;
using VinoApp.Servicios;

namespace VinoApp.Formularios.Bodegas
{
    public partial class PantallaImportadorBodega : Form
    {
        // Atributo
        private GestorImportadorBodega _gestor;
        private List<Bodega> _bodegas;

        public PantallaImportadorBodega(GestorImportadorBodega gestor)
        {
            _gestor = gestor;
            InitializeComponent();
        }

        private void PantallaImportadorBodega_Load(object sender, EventArgs e)
        {
            _bodegas = _gestor.BuscarBodegasParaActualizar().Where(b => NecesitaActualizacion(b)).ToList();
            Debug.WriteLine($"Número de bodegas que necesitan actualización: {_bodegas.Count}");
            mostrarBodegasParaActualizar();
        }

        private void mostrarBodegasParaActualizar()
        {
            listViewBodegas.Items.Clear();

            foreach (var bodega in _bodegas)
            {
                ListViewItem item = new ListViewItem(bodega.Nombre);
                item.Tag = bodega;  // Guardar la bodega en la propiedad Tag del ListViewItem
                listViewBodegas.Items.Add(item);
            }
        }

        private bool NecesitaActualizacion(Bodega bodega)
        {
            bool necesitaActualizacion = (DateTime.Now - bodega.FechaUltimaActualizacion).TotalDays >= bodega.PeriodoActualizacion;
            Debug.WriteLine($"La bodega {bodega.Nombre} necesita actualización: {necesitaActualizacion}");
            return necesitaActualizacion;
        }

        private void listViewBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBodegas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewBodegas.SelectedItems[0];
                Bodega bodegaSeleccionada = selectedItem.Tag as Bodega;
                if (bodegaSeleccionada != null)
                {
                    tomarSeleccionBodega(bodegaSeleccionada);
                }
            }
        }

        private void tomarSeleccionBodega(Bodega bodega)
        {
            InterfazAPIBodega verBodegaForm = new InterfazAPIBodega(bodega);
            verBodegaForm.ShowDialog();
        }
    }
}

