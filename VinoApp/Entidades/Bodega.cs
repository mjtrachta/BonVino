using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinoApp.Modelos;

namespace VinoApp.Endidades
{
    public class Bodega
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CoordenadasUbicacion { get; set; }
        public string Historia { get; set; }
        public int PeriodoActualizacion { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }
        public RegionVitivinicola Region { get; set; }
        public List<Vino> Vinos { get; set; }

        public Bodega(string nombre, string descripcion, string coordenadasUbicacion, string historia, int periodoActualizacion, DateTime fechaUltimaActualizacion, RegionVitivinicola region, List<Vino> vinos)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            CoordenadasUbicacion = coordenadasUbicacion;
            Historia = historia;
            PeriodoActualizacion = periodoActualizacion;
            FechaUltimaActualizacion = fechaUltimaActualizacion;
            Region = region;
            Vinos = vinos ?? new List<Vino>();
        }

        

        // Método para verificar si la bodega necesita actualización
        // Método 4
        public bool EstaParaActualizarNovedadesVino()
        {
            bool estaParaActualizarNovedadesVino = ((DateTime.Now - FechaUltimaActualizacion).TotalDays)/30 >= PeriodoActualizacion;
            return estaParaActualizarNovedadesVino;
        }

        // Método 5
        //Revisar
        public string getNombre()
        {
            return Nombre;
        }
        /* public string getNombre(Bodega bodega)
         {
             return Nombre;
         }*/


        //Método 11
        public void ActualizarDatosVinos(List<Vino> nuevosVinos)
        {
            foreach (var nuevoVino in nuevosVinos)
            {
                var vinoExistente = this.Vinos.FirstOrDefault(v => v.sosVinoParaActualizar(nuevoVino));
                if (vinoExistente != null)
                {
                    if (nuevoVino.PrecioArs != 0)
                        vinoExistente.setPrecio(nuevoVino.PrecioArs);

                    if (!string.IsNullOrEmpty(nuevoVino.NotaDeCataBodega))
                        vinoExistente.setNotaCata(nuevoVino.NotaDeCataBodega);

                    if (!string.IsNullOrEmpty(nuevoVino.ImagenEtiqueta))
                        vinoExistente.setImagenEtiqueta(nuevoVino.ImagenEtiqueta);
                }
            }
        }
    }
}