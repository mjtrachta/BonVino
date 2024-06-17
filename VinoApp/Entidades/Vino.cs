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
        public List<Maridaje> Maridaje { get; set; }

        public List<Varietal> Varietal { get; set; }

        public Bodega Bodega { get; set; } // Referencia a la bodega a la que pertenece este vino

        public Vino() { }

        // Metodo new vinos
        public Vino(string nombre, string aniada, string imagenEtiqueta, string notaDeCataBodega, double precioArs, List<Maridaje> maridaje, List<Varietal> varietal, Bodega bodega)
        {
            Nombre = nombre;
            Aniada = aniada;
            ImagenEtiqueta = imagenEtiqueta;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioArs = precioArs;
            Maridaje = maridaje ?? new  List<Maridaje>();
            Varietal = varietal ?? new List<Varietal>();
            Bodega = bodega;
        }

        //Método 12

        public bool sosVinoParaActualizar(Vino otroVino)
        {
            return this.Nombre == otroVino.Nombre;
        }

        //Método 13
        public void setPrecio(double precio)
        {
            this.PrecioArs = precio;
        }

        //Método 14
        public void setNotaCata(string notaCata)
        {
            this.NotaDeCataBodega = notaCata;
        }

        //Método 15
        public void setImagenEtiqueta(string imagen)
        {
            this.ImagenEtiqueta = imagen;
        }
    }







}

