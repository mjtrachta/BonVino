using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinoApp.Modelos
{
    public class Varietal
    {
        public string Descripcion { get; set; }
        public double PorcentajeComposicion { get; set; }
        public TipoUva TipoUva { get; set; }

        // Método new de Varietal
        public Varietal(string descripcion, double porcentajeComposicion, TipoUva tipoUva)
        {
            Descripcion = descripcion;
            PorcentajeComposicion = porcentajeComposicion;
            TipoUva = tipoUva;
        }
    }
}
