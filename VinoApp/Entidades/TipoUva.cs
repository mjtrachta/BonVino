using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class TipoUva
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Varietal> Varietales { get; set; }

        public TipoUva()
        {
            Varietales = new List<Varietal>();
        }

 

        public TipoUva(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Varietales = new List<Varietal>();
        }

        public bool sosTipoUva(TipoUva tipoUva)
        {
            return this.Nombre == tipoUva.Nombre;
        }
    }
}
