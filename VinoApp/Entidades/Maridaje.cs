using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class Maridaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public bool sosMaridaje(Maridaje maridaje)
        {
            return this.Nombre == maridaje.Nombre;
        }
    }
}
