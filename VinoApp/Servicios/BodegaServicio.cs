using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinoApp.Endidades;
using VinoApp.Modelos;

namespace VinoApp.Servicios
{
    public class BodegaServicio
    {
        private List<Bodega> bodegas;

        public BodegaServicio()
        {
            // Inicializar con algunos datos de ejemplo
            bodegas = new List<Bodega>
            {
                new Bodega("Bodega 1", "Descripción de la Bodega 1", "123, 456", "Historia de la Bodega 1", "2024-05-28"),
                new Bodega("Bodega 2", "Descripción de la Bodega 2", "789, 012", "Historia de la Bodega 2", "2024-05-28")
            };

            // Agregar vinos a las bodegas
            var vino1 = new Vino("Vino 1", "2020", "imagen_vino1.jpg", "Nota de cata del Vino 1", 250.00, new Maridaje(), new Varietal(), bodegas[0]);
            var vino2 = new Vino("Vino 2", "2019", "imagen_vino2.jpg", "Nota de cata del Vino 2", 180.00, new Maridaje(), new Varietal(), bodegas[0]);
            var vino3 = new Vino("Vino 3", "2018", "imagen_vino3.jpg", "Nota de cata del Vino 3", 300.00, new Maridaje(), new Varietal(), bodegas[1]);
            var vino4 = new Vino("Vino 4", "2017", "imagen_vino4.jpg", "Nota de cata del Vino 4", 220.00, new Maridaje(), new Varietal(), bodegas[1]);

            bodegas[0].Vinos.Add(vino1);
            bodegas[0].Vinos.Add(vino2);
            bodegas[1].Vinos.Add(vino3);
            bodegas[1].Vinos.Add(vino4);
        }

        public List<Bodega> ObtenerBodegas()
        {
            return bodegas;
        }

        public void AplicarActualizacionesDesdeJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var actualizaciones = JsonConvert.DeserializeObject<List<Bodega>>(json);

            foreach (var actualizacion in actualizaciones)
            {
                var bodega = bodegas.Find(b => b.Nombre == actualizacion.Nombre);
                if (bodega != null)
                {
                    bodega.ActualizarDatos(
                        actualizacion.CoordenadasUbicacion,
                        actualizacion.Historia,
                        actualizacion.Descripcion,
                        actualizacion.PeriodoActualizacion,
                        actualizacion.Vinos
                    );
                }
            }
        }
    }
}
