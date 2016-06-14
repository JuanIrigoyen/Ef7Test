using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_proveedores_articulos_presupuestados
    {
        public int Codigo { get; set; }
        public int? Codigo_proforma { get; set; }
        public string Proforma { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precios { get; set; }
        public decimal Descuento { get; set; }
        public int Plazo { get; set; }
    }
}
