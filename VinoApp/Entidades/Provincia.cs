using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class Provincia
    {
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public List<RegionVitivinicola> Regiones { get; set; }

        public Provincia()
        {
            Regiones = new List<RegionVitivinicola>();
        }

        public Provincia(string nombre, Pais pais)
        {
            Nombre = nombre;
            Pais = pais;
            Regiones = new List<RegionVitivinicola>();
        }
    }
}
