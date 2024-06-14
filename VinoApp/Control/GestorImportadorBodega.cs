using System;
using System.Collections.Generic;
using VinoApp.Endidades;

namespace VinoApp.Servicios
{
    public class GestorImportadorBodega
    {
        private List<Bodega> _bodegas;

        public GestorImportadorBodega()
        {
            _bodegas = new List<Bodega>();
        }

        public void AsignarBodegas(List<Bodega> bodegas)
        {
            _bodegas = bodegas;
            // Imprimir el número de bodegas asignadas
            Console.WriteLine($"Número de bodegas asignadas: {_bodegas.Count}");
        }

        public List<Bodega> BuscarBodegasParaActualizar()
        {
            return _bodegas;
        }
    }
}
