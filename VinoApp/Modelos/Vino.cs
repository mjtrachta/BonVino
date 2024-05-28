using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinoApp.Endidades;

namespace VinoApp.Modelos
{
    public class Vino
    {
        public string Nombre { get; set; }
        public string Aniada { get; set; }
        public string ImagenEtiqueta { get; set; }
        public string NotaDeCataBodega { get; set; }
        public double PrecioArs { get; set; }
        public Maridaje Maridaje { get; set; }
        public Varietal Varietal { get; set; }
        public Bodega Bodega { get; set; } // Referencia a la bodega a la que pertenece este vino

        public Vino() { }

        public Vino(string nombre, string aniada, string imagenEtiqueta, string notaDeCataBodega, double precioArs, Maridaje maridaje, Varietal varietal, Bodega bodega)
        {
            Nombre = nombre;
            Aniada = aniada;
            ImagenEtiqueta = imagenEtiqueta;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioArs = precioArs;
            Maridaje = maridaje;
            Varietal = varietal;
            Bodega = bodega;
        }

        public override bool Equals(object obj)
        {
            return obj is Vino vino && Nombre == vino.Nombre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nombre);
        }
    }
}
