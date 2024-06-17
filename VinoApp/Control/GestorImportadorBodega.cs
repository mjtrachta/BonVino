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
            var json = ObtenerActualizacionVinoBodega(bodega);


            InterfazAPIBodega instanciaInterfaz = new InterfazAPIBodega(bodega);
            instanciaInterfaz.obtenerActualizacionVino(json);
            actualizarCaracteristicasVinoExistente(json.Vinos);
            crearVinos(json.Vinos, bodega);
            InterfazNotificacion instanciaNotificacion = new InterfazNotificacion();
            instanciaNotificacion.notificarNovedadVinoParaBodega();



            // Mostrar mensaje de confirmación con información de vinos actualizados
            string mensaje = "Los vinos de la " + bodega.Nombre + " se han actualizado correctamente.\n\n";
            mensaje += "**Detalles de los vinos actualizados y creados:**\n";

            foreach (var vinoExistente in bodega.Vinos)
            {
                // Buscar el vino correspondiente en el JSON
                var nuevoVino = json.Vinos.FirstOrDefault(v => v.Nombre == vinoExistente.Nombre);

                // Si se encuentra el vino correspondiente
                //if (vinoExistente != null)
                if (nuevoVino != null)
                {
                    // Mostrar los atributos actualizados del vino existente
                    string mensajeVino = "\n**Vino:** " + vinoExistente.Nombre + "\n";
                    mensajeVino += "  * **Nombre:** " + vinoExistente.Nombre + "\n";
                    mensajeVino += "  * **Imagen Etiqueta:** " + vinoExistente.ImagenEtiqueta + "\n";
                    mensajeVino += "  * **Nota De Cata Bodega:** " + vinoExistente.NotaDeCataBodega + "\n";
                    mensajeVino += "  * **Precio Ars:** " + vinoExistente.PrecioArs.ToString("C2") + "\n";

                    // Concatenar el mensaje del vino al mensaje principal
                    mensaje += mensajeVino;
                }
            }
            
            DialogResult resultado = MessageBox.Show(mensaje, "Actualización completada",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar estado de la bodega 
            if (resultado == DialogResult.OK)
            {

                bodega.FechaUltimaActualizacion = DateTime.Now;
            }
        }

        //Método 8
        private Bodega ObtenerActualizacionVinoBodega(Bodega bodega)
        {
                string jsonContent = File.ReadAllText(rutaArchivoActualizaciones);
                var actualizaciones = JsonConvert.DeserializeObject<List<Bodega>>(jsonContent);

                 var actualizacionBodega = actualizaciones.FirstOrDefault(b => b.Nombre == bodega.Nombre);

                return actualizacionBodega;  
        }

        //Método 10
        // este metodo se usa para evitar que los datos se pisen aca arriba. falta implementarlo

        public void actualizarCaracteristicasVinoExistente(List<Vino> actualizacionVinos)
        {
            foreach (var bodega in datosBodegas)
            {
                bodega.ActualizarDatosVinos(actualizacionVinos);
            }
        }

        // Método para crear nuevos vinos
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

    

