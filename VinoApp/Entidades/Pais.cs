using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class Pais
    {
        public string Nombre { get; set; }
        public List<Provincia> Provincias { get; set; }

        public Pais()
        {
            Provincias = new List<Provincia>();
        }

        public Pais(string nombre)
        {
            Nombre = nombre;
            Provincias = new List<Provincia>();
        }
    }
}
