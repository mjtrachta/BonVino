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
using VinoApp.Boundary.Bodegas;

namespace VinoApp.Servicios
{
    public class GestorImportadorBodega
    {
        private List<Bodega> datosBodegas;
        public PantallaImportadorBodega pantalla;
        private string rutaArchivoActualizaciones = @"C:\Users\DELL\Desktop\VinoApp\VinoApp\Datos\actualizaciones.json";
        public InterfazAPIBodega interfazAPIBodega;
        public InterfazNotificacion interfazNotificacion;

        public GestorImportadorBodega(PantallaImportadorBodega pantalla)
        {
            this.pantalla = pantalla;
            datosBodegas = new List<Bodega>();
        }


        ///////////////////////////////////////////////////////
        public void AsignarBodegas(List<Bodega> bodegas)
        {
            datosBodegas = bodegas;
        }
        ///////////////////////////////////////////////////////
        

        //// Método 1
        public List<Bodega> OpcionImportarActualizacionVinos()
        {
            return BuscarBodegasParaActualizar();
        }

        // Método 3 (obtener todas las bodegas que necesitan actualización)
        public List<Bodega> BuscarBodegasParaActualizar()
        {
            return datosBodegas.Where(b => b.EstaParaActualizarNovedadesVino()).ToList();
        }

        //Método 7
        public void tomarSeleccionBodega(Bodega bodega)
        {
                      // Uso Método 8
            var json = ObtenerActualizacionVinoBodega(bodega);

            InterfazAPIBodega instanciaInterfaz = new InterfazAPIBodega(bodega);
            instanciaInterfaz.obtenerActualizacionVino(json);

            actualizarCaracteristicasVinoExistente(json.Vinos);
            crearVinos(json.Vinos, bodega);


            // Mostrar resumen de los vinos actualizados y creados
            pantalla.mostrarResumenVinosImportados(bodega, json.Vinos);


            InterfazNotificacion instanciaNotificacion = new InterfazNotificacion();
            instanciaNotificacion.notificarNovedadVinoParaBodega();
        }

        //Método 8
        private Bodega ObtenerActualizacionVinoBodega(Bodega bodega)
        {
                string jsonContent = File.ReadAllText(rutaArchivoActualizaciones);
                var actualizaciones = JsonConvert.DeserializeObject<List<Bodega>>(jsonContent);

                 var actualizacionBodega = actualizaciones.FirstOrDefault(b => b.Nombre == bodega.Nombre);

                return actualizacionBodega;  
        }

        //Método 10(para actualizar vinos)
        public void actualizarCaracteristicasVinoExistente(List<Vino> actualizacionVinos)
        {
            foreach (var bodega in datosBodegas)
            {
                bodega.ActualizarDatosVinos(actualizacionVinos);
            }
        }

        // Método 16 (verificar si existe maridaje)
        public bool buscaMaridaje(Maridaje maridaje)
        {
            foreach (var bodega in datosBodegas)
            {
                foreach (var vino in bodega.Vinos)
                {
                    if (vino.Maridaje.Any(m => m.sosMaridaje(maridaje)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        // Método 18 (verificar si existe tipo de uva)
        public bool buscaTipoUva(TipoUva tipoUva)
        {
            foreach (var bodega in datosBodegas)
            {
                foreach (var vino in bodega.Vinos)
                {
                    if (vino.Varietal.Any(v => v.TipoUva.sosTipoUva(tipoUva)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Método 20 (para crear nuevos vinos)
        public void crearVinos(List<Vino> actualizacionVinos, Bodega bodega)
        {
            foreach (var vinoNuevo in actualizacionVinos)
            {
                if (!bodega.Vinos.Any(v => v.Nombre == vinoNuevo.Nombre))
                {
                    var nuevoVino = new Vino(vinoNuevo.Nombre, vinoNuevo.Aniada, vinoNuevo.ImagenEtiqueta, vinoNuevo.NotaDeCataBodega, vinoNuevo.PrecioArs, vinoNuevo.Maridaje, vinoNuevo.Varietal, bodega);
                    bodega.Vinos.Add(nuevoVino);
                }
            }
        }
       
    }


}

    

