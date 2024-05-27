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
using VinoApp.Servicios;

namespace VinoApp.Formularios.Bodegas
{
    public partial class ModificarBodegas : Form
    {
        private BodegaServicio _bodegaServicio;
        private List<Bodega> _bodegas;

        public ModificarBodegas()
        {
            InitializeComponent();
            _bodegaServicio = new BodegaServicio();
            _bodegas = _bodegaServicio.ObtenerBodegas();
            CrearBotonesDeBodegas();
        }

        private void CrearBotonesDeBodegas()
        {
            int yPosition = 10;

            foreach (var bodega in _bodegas)
            {
                Button bodegaButton = new Button
                {
                    Text = bodega.Nombre,
                    Location = new System.Drawing.Point(10, yPosition),
                    Width = 200
                };
                bodegaButton.Click += (sender, e) => MostrarDetallesBodega(bodega);
                this.Controls.Add(bodegaButton);
                yPosition += 40;
            }
        }

        private void MostrarDetallesBodega(Bodega bodega)
        {
            VerBodega verBodegaForm = new VerBodega(bodega);
            verBodegaForm.ShowDialog();
        }
    }
}
