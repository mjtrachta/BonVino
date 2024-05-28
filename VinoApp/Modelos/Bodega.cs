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
        public string CoordenadasUbicacion { get; set; }
        public string Historia { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string PeriodoActualizacion { get; set; }
        public List<Vino> Vinos { get; set; }

        public Bodega(string nombre, string descripcion, string coordenadasUbicacion, string historia, string periodoActualizacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            CoordenadasUbicacion = coordenadasUbicacion;
            Historia = historia;
            PeriodoActualizacion = periodoActualizacion;
            Vinos = new List<Vino>();
        }

        public void ActualizarDatos(string coordenadasUbicacion, string historia, string descripcion, string periodoActualizacion, List<Vino> vinosActualizados)
        {
            CoordenadasUbicacion = coordenadasUbicacion;
            Historia = historia;
            Descripcion = descripcion;
            PeriodoActualizacion = periodoActualizacion;
            Vinos = vinosActualizados;
        }
    
    }
}
