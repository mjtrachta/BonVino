using VinoApp.Endidades;
using System;
using System.Collections.Generic;
using VinoApp.Datos;
using VinoApp.Endidades;
using VinoApp.Formularios.Bodegas;
using VinoApp.Modelos;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using VinoApp.Endidades;

namespace VinoApp.Servicios
{
    public class GestorImportadorBodega
    {
        private List<Bodega> datosBodegas;
        private PantallaImportadorBodega pantalla;

        public GestorImportadorBodega(PantallaImportadorBodega pantalla)
        {
            this.pantalla = pantalla;
            datosBodegas = new List<Bodega>();
        }

        public void AsignarBodegas(List<Bodega> bodegas)
        {
            datosBodegas = bodegas;
        }

        //// Método 1
        public List<Bodega> OpcionImportarActualizacionVinos()
        {
            return BuscarBodegasParaActualizar();
        }

        // Método para obtener todas las bodegas que necesitan actualización
        // Método 3
        public List<Bodega> BuscarBodegasParaActualizar()
        {
            return datosBodegas.Where(b => b.EstaParaActualizarNovedadesVino()).ToList();
        }

    

        // Este método debería llamar al método de instancia en la entidad Bodega
        public string ObtenerNombreBodega(Bodega bodega)
        {
            return bodega.getNombre();
        }
   
    }
}

