using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class Vino
    {
        public string Aniada { get; set; } 
        public string ImagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public string NotaDeCataBodega { get; set; }
        public double PrecioArs { get; set; }
        public Maridaje Maridaje { get; set; }
        public Varietal Varietal { get; set; }
    }
}
