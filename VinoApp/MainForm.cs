using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using VinoApp.Datos;
using VinoApp.Endidades;
using VinoApp.Formularios.Bodegas;
using VinoApp.Servicios;

namespace VinoApp
{
    public partial class MainForm : Form
    {
        private GeneradorDeDatos _generadorDeDatos;
        private GestorImportadorBodega _gestorImportadorBodega;

        public MainForm()
        {
            InitializeComponent();
            _generadorDeDatos = new GeneradorDeDatos();
            _gestorImportadorBodega = new GestorImportadorBodega();
            CargarBodegas();
        }

        private void CargarBodegas()
        {
            var bodegas = _generadorDeDatos.ObtenerBodegas();
            _gestorImportadorBodega.AsignarBodegas(bodegas);
            // Imprimir el número de bodegas cargadas
            Debug.WriteLine($"Número de bodegas cargadas: {bodegas.Count}");
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para el menú Archivo
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaImportadorBodega modificarBodegasForm = new PantallaImportadorBodega(_gestorImportadorBodega);
            modificarBodegasForm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para el menú Bodegas
        }
    }
}
