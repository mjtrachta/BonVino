using System;
using System.Collections.Generic;
using VinoApp.Endidades;
using VinoApp.Modelos;

namespace VinoApp.Datos
{
    internal class GeneradorDeDatos
    {
        private List<Bodega> bodegas;
        private List<Vino> vinos;
        private List<Maridaje> maridajes;
        private List<Varietal> varietales;
        private List<RegionVitivinicola> regiones;
        private List<Provincia> provincias;
        private List<Pais> paises;
        private List<TipoUva> tiposUva;

        public GeneradorDeDatos()
        {


            // Crear Países
            Pais pais1 = new Pais("Argentina");
            paises = new List<Pais> { pais1 };

            // Crear Provincias
            Provincia provincia1 = new Provincia("Mendoza", pais1);
            Provincia provincia2 = new Provincia("San Juan", pais1);

            pais1.Provincias.Add(provincia1);
            pais1.Provincias.Add(provincia2);

            provincias = new List<Provincia> { provincia1, provincia2 };

            // Crear Regiones Vitivinícolas
            RegionVitivinicola region1 = new RegionVitivinicola("Valle de Uco", provincia1);
            RegionVitivinicola region2 = new RegionVitivinicola("Pedernal", provincia2);

            provincia1.Regiones.Add(region1);
            provincia2.Regiones.Add(region2);

            regiones = new List<RegionVitivinicola> { region1, region2 };

            // Crear Tipos de Uva
            TipoUva tipoUva1 = new TipoUva("Malbec", "Uva tinta");
            TipoUva tipoUva2 = new TipoUva("Cabernet Sauvignon", "Uva tinta");

            tiposUva = new List<TipoUva> { tipoUva1, tipoUva2 };

            // Crear Varietales
            Varietal varietal1 = new Varietal("Malbec", 100, tipoUva1);
            Varietal varietal2 = new Varietal("Cabernet Sauvignon", 100, tipoUva2);

            tipoUva1.Varietales.Add(varietal1);
            tipoUva2.Varietales.Add(varietal2);

            varietales = new List<Varietal> { varietal1, varietal2 };

            // Crear Maridajes
            Maridaje maridaje1 = new Maridaje { Nombre = "Carne Asada", Descripcion = "Perfecto para carnes asadas" };
            Maridaje maridaje2 = new Maridaje { Nombre = "Pescado", Descripcion = "Ideal con pescado" };
            Maridaje maridaje3 = new Maridaje { Nombre = "Queso", Descripcion = "Combina bien con quesos fuertes" };

            maridajes = new List<Maridaje> { maridaje1, maridaje2, maridaje3 };

            // Crear Bodegas
            DateTime fechaActual = DateTime.Now;
            Bodega bodega1 = new Bodega("Bodega Los Andes", "Ubicada en Mendoza", "32°53'S 68°51'W", "Una bodega histórica", 12, fechaActual.AddDays(-15), region1, new List<Vino>());
            Bodega bodega2 = new Bodega("Bodega La Cava", "Ubicada en San Juan", "31°32'S 68°31'W", "Con tradición familiar", 24, fechaActual.AddDays(-30), region2, new List<Vino>());
            Bodega bodega3 = new Bodega("Bodega SIN VINOS", "Ubicada en San Juan", "34°33'S 67°30'W", "Con pasas de uvas", 24, fechaActual.AddDays(-1), region2, new List<Vino>());

            bodegas = new List<Bodega> { bodega1, bodega2, bodega3 };

            // Crear Vinos y asignarlos a bodegas
            Vino vino1 = new Vino("Reserva Malbec", "2018", "reserva_malbec.jpg", "Notas de frutos rojos y especias", 500, new List<Maridaje> { maridaje1 }, new List<Varietal> { varietal1 }, bodega1);
            Vino vino2 = new Vino("Gran Reserva Cabernet", "2019", "gran_reserva_cabernet.jpg", "Aromas a pimiento y chocolate", 750, new List<Maridaje> { maridaje2 }, new List<Varietal> { varietal2 }, bodega1);
            Vino vino3 = new Vino("Rosado", "2020", "rosado.jpg", "Fresco y afrutado", 300, new List<Maridaje> { maridaje3 }, new List<Varietal> { varietal1, varietal2 }, bodega2);

            vinos = new List<Vino> { vino1, vino2, vino3 };

            bodega1.Vinos.Add(vino1);
            bodega1.Vinos.Add(vino2);
            bodega2.Vinos.Add(vino3);
        }

        public List<Bodega> ObtenerBodegas()
        {
            return bodegas;
        }

        public List<Vino> ObtenerVinos()
        {
            return vinos;
        }

        public List<Maridaje> ObtenerMaridajes()
        {
            return maridajes;
        }

        public List<Varietal> ObtenerVarietales()
        {
            return varietales;
        }

        public List<RegionVitivinicola> ObtenerRegiones()
        {
            return regiones;
        }

        public List<Provincia> ObtenerProvincias()
        {
            return provincias;
        }

        public List<Pais> ObtenerPaises()
        {
            return paises;
        }

        public List<TipoUva> ObtenerTiposUva()
        {
            return tiposUva;
        }
    }
}
