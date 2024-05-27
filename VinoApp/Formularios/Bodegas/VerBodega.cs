using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinoApp.Endidades;

namespace VinoApp.Formularios.Bodegas
{
    public partial class VerBodega : Form
    {
        private Bodega _bodega;

        public VerBodega(Bodega bodega)
        {
            InitializeComponent();
            _bodega = bodega;
            MostrarDetallesBodega();
        }

        private void MostrarDetallesBodega()
        {
            // Mostrar los detalles de la bodega en los controles del formulario
            // Por ejemplo:
            //txtNombre.Text = _bodega.Nombre;
            //txtDescripcion.Text = _bodega.Descripcion;
            // Continuar con el resto de los campos
        }
    }
}
