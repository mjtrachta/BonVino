using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinoApp.Endidades;

namespace VinoApp.Servicios
{
    public class BodegaServicio
    {
        private List<Bodega> bodegas;

        public BodegaServicio()
        {
            // Inicializar con algunos datos de ejemplo
            bodegas = new List<Bodega>
            {
                new Bodega { Nombre = "Bodega 1", Descripcion = "Descripcion 1" },
                new Bodega { Nombre = "Bodega 2", Descripcion = "Descripcion 2" },
                new Bodega { Nombre = "Bodega 3", Descripcion = "Descripcion 3" },
                new Bodega { Nombre = "Bodega 4", Descripcion = "Descripcion 4" }
            };
        }

        public List<Bodega> ObtenerBodegas()
        {
            return bodegas;
        }
    }
}
