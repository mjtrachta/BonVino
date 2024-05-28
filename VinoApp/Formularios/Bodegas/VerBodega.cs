using Newtonsoft.Json;
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
        private Bodega _bodegaActualizacion;

        public VerBodega(Bodega bodega)
        {
            InitializeComponent();
            _bodega = bodega;
            CargarDatosBodega();
            CargarVinos();
            CargarDatosBodegaJson();
            CargarVinoJson();
        }

        private void CargarDatosBodega()
        {
            // Mostrar los detalles de la bodega en los controles del formulario
            nombreTextBox1.Text = _bodega.Nombre;
            descripcionTextBox2.Text = _bodega.Descripcion;
            periodoTextBox3.Text = _bodega.PeriodoActualizacion;
            coordenadaTextBox4.Text = _bodega.CoordenadasUbicacion;
        }

        private void CargarVinos()
        {
            vinosListBox1.Items.Clear();
            foreach (var vino in _bodega.Vinos)
            {
                vinosListBox1.Items.Add(vino.Nombre);
            }
        }

        private void CargarDatosBodegaJson()
        {
            // Ruta relativa al archivo JSON dentro del directorio de salida de la aplicación
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "actualizaciones.json");
            string jsonContent = File.ReadAllText(jsonFilePath);
            var bodegasActualizacion = JsonConvert.DeserializeObject<List<Bodega>>(jsonContent);

            // Buscar la actualización correspondiente a esta bodega
            _bodegaActualizacion = bodegasActualizacion?.Find(b => b.Nombre == _bodega.Nombre);

            if (_bodegaActualizacion != null)
            {
                // Mostrar los datos de actualización en los controles del formulario
                nombreActTextBox1.Text = _bodegaActualizacion.Nombre;
                descripcionActTextBox2.Text = _bodegaActualizacion.Descripcion;
                periodoActTextBox3.Text = _bodegaActualizacion.PeriodoActualizacion;
                coordenadaActTextBox4.Text = _bodegaActualizacion.CoordenadasUbicacion;
            }
        }

        private void CargarVinoJson()
        {
            vinosActListBox1.Items.Clear();
            if (_bodegaActualizacion != null)
            {
                foreach (var vino in _bodegaActualizacion.Vinos)
                {
                    vinosActListBox1.Items.Add(vino.Nombre);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Actualizar los datos de la bodega con los datos del JSON
            if (_bodegaActualizacion != null)
            {
                _bodega.Nombre = _bodegaActualizacion.Nombre;
                _bodega.Descripcion = _bodegaActualizacion.Descripcion;
                _bodega.PeriodoActualizacion = _bodegaActualizacion.PeriodoActualizacion;
                _bodega.CoordenadasUbicacion = _bodegaActualizacion.CoordenadasUbicacion;

                // Actualizar la lista de vinos sin duplicar
                foreach (var vino in _bodegaActualizacion.Vinos)
                {
                    var existingVino = _bodega.Vinos.FirstOrDefault(v => v.Equals(vino));
                    if (existingVino != null)
                    {
                        existingVino.Aniada = vino.Aniada;
                        existingVino.ImagenEtiqueta = vino.ImagenEtiqueta;
                        existingVino.NotaDeCataBodega = vino.NotaDeCataBodega;
                        existingVino.PrecioArs = vino.PrecioArs;
                    }
                    else
                    {
                        _bodega.Vinos.Add(vino);
                    }
                }

                // Recargar los datos actualizados en los controles
                CargarDatosBodega();
                CargarVinos();
            }
        }
    }
}
