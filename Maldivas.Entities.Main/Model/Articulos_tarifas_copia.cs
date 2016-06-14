using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_tarifas_copia
    {
        public int Codigo { get; set; }
        public int Tarifa { get; set; }
        public string Articulo { get; set; }
        public decimal Precio { get; set; }
        public string Situacion { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public decimal Descuento { get; set; }
        public decimal Recargo { get; set; }
        public decimal Total { get; set; }
        public string Divisa { get; set; }
        public decimal Precio_anterior { get; set; }
        public int Operacion { get; set; }
        public DateTime Fecha_copia { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Precios_copias OperacionNavigation { get; set; }
        public virtual Clientes_precios_tipos SituacionNavigation { get; set; }
    }
}
