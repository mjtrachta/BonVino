using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class Enofilo
    {
        public string Apellido { get; set; }
        public string ImagenPerfil { get; set; }
        public string Nombre { get; set; }
        public Usuario Usuario { get; set; }
        public Siguiendo Siguiendo { get; set; }
    }
}
