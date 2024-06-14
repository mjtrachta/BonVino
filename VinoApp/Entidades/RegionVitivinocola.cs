using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class RegionVitivinicola
    {
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }

        public RegionVitivinicola(string nombre, Provincia provincia)
        {
            Nombre = nombre;
            Provincia = provincia;
        }
    }
}
