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

        public Bodega()
        {
            Vinos = new List<Vino>();
        }
    }
}
