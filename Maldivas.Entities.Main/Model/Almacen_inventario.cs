using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Almacen_inventario
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int? Lote { get; set; }
        public string Lote_externo { get; set; }
        public string Referencia_base { get; set; }
        public DateTime? Fecha { get; set; }
        public int Existencias { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Precio_ultima_compra { get; set; }
        public decimal Precio_medio { get; set; }
        public decimal? Valor { get; set; }
    }
}
