using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_stocks_auditacion
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Articulo { get; set; }
        public string Ubicacion { get; set; }
        public decimal? Stock_fecha_maldivas { get; set; }
        public decimal? Stock_fecha_real { get; set; }
    }
}
