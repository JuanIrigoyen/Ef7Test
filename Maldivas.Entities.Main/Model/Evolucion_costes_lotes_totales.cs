using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Evolucion_costes_lotes_totales
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public int? TamañoLote { get; set; }
        public decimal? CosteAdquisicionTotalLote { get; set; }
        public decimal? CosteAdquisicionUnidad { get; set; }
        public decimal? CosteMantenimientoTotalLote { get; set; }
        public decimal? CosteMantenimientoUnidad { get; set; }
        public decimal? TotalCosteUnidad { get; set; }
        public string Porcentaje { get; set; }
        public bool? LoteOptimo { get; set; }
        public bool? LoteOptimoActual { get; set; }
    }
}
