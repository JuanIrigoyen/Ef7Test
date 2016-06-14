using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_troqueles_costo_compra
    {
        public string Articulo { get; set; }
        public string Identificacion { get; set; }
        public DateTime? Fecha_compra { get; set; }
        public string Proveedor { get; set; }
        public decimal Coste { get; set; }
        public string Tipo { get; set; }
    }
}
