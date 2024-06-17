using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VinoApp.Endidades;
using VinoApp.Servicios;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VinoApp.Endidades;
using VinoApp.Servicios;

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
            {                                               // Revisar ObtenerNombreBodega del gestor
                ListViewItem item = new ListViewItem(gestor.ObtenerNombreBodega(bodega));
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

    }
}


