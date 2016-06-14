using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_precios_compra
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Proveedor { get; set; }
        public decimal Precio { get; set; }
        public decimal Coste_adicional { get; set; }
        public string Divisa { get; set; }
        public int Clasificacion { get; set; }
        public int Cantidad_inicial { get; set; }
        public int Cantidad_final { get; set; }
        public decimal Descuento { get; set; }
        public decimal Recargo { get; set; }
        public decimal Total { get; set; }
        public DateTime? Fecha { get; set; }
        public string Lote { get; set; }
        public int Plazo_entrega { get; set; }
        public decimal Factor { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
