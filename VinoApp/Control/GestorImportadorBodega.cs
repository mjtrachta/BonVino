using VinoApp.Endidades;
using System;
using System.Collections.Generic;
using VinoApp.Datos;
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
using Newtonsoft.Json;

namespace VinoApp.Servicios
{
    public class GestorImportadorBodega
    {
        private List<Bodega> datosBodegas;
        private PantallaImportadorBodega pantalla;
        private string rutaArchivoActualizaciones = @"C:\Users\DELL\Desktop\VinoApp\VinoApp\Datos\actualizaciones.json";
        private InterfazAPIBodega interfazAPIBodega;

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

        //Método 7
        public void tomarSeleccionBodega(Bodega bodega)
        {
            ObtenerActualizacionVinoBodega(bodega);
            InterfazAPIBodega instanciaInterfaz = new InterfazAPIBodega(bodega);
            instanciaInterfaz.obtenerActualizacionVino(bodega);
        }


        //Método 8

        private void ObtenerActualizacionVinoBodega(Bodega bodega)
        {
            if (File.Exists(rutaArchivoActualizaciones))
            {
                string jsonContent = File.ReadAllText(rutaArchivoActualizaciones);
                var actualizaciones = JsonConvert.DeserializeObject<List<Bodega>>(jsonContent);

                var actualizacionBodega = actualizaciones.FirstOrDefault(b => b.Nombre == bodega.Nombre);
                if (actualizacionBodega != null)
                {
                    //Esto pisa los datos de vinos en la bodega
                    bodega.Vinos = actualizacionBodega.Vinos;
                    bodega.FechaUltimaActualizacion = DateTime.Now;
                }
            }
        }

        //Método 10
        // este metodo se usa para evitar que los datos se pisen aca arriba. falta implementarlo

        /*
        public void actualizarCaracteristicasVinoExistente(List<Vino> nuevosVinos)
        {
            foreach (var bodega in datosBodegas)
            {
                bodega.ActualizarDatosVinos(nuevosVinos);
            }
        }
        */
        public void actualizarCaracteristicasVinoExistente(List<Vino> nuevosVinos)
        {
            foreach (var bodega in datosBodegas)
            {
                foreach (var vinoExistente in bodega.Vinos)
                {
                    var vinoActualizado = nuevosVinos.FirstOrDefault(v => v.sosVinoParaActualizar(vinoExistente));

                    if (vinoActualizado != null)
                    {
                        if (vinoActualizado.PrecioArs != 0)
                            vinoExistente.setPrecio(vinoActualizado.PrecioArs);

                        if (!string.IsNullOrEmpty(vinoActualizado.NotaDeCataBodega))
                            vinoExistente.setNotaCata(vinoActualizado.NotaDeCataBodega);

                        if (!string.IsNullOrEmpty(vinoActualizado.ImagenEtiqueta))
                            vinoExistente.setImagenEtiqueta(vinoActualizado.ImagenEtiqueta);
                    }
                }
            }
        }




    }
}


