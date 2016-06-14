using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_albaranes_entradas
    {
        public int Codigo { get; set; }
        public DateTime? Fecha_entrada { get; set; }
        public string Articulo { get; set; }
        public string Tracking { get; set; }
        public int? Pedido_numero_linea { get; set; }
        public int? Albaran { get; set; }
        public string Jaula { get; set; }
        public int Cantidad { get; set; }
        public string Picking_almacen { get; set; }
        public string Picking_ubicacion { get; set; }
        public string Entradas_almacen { get; set; }
        public string Entradas_ubicacion { get; set; }
        public string Operario { get; set; }
        public bool Entrada { get; set; }
        public bool Stock { get; set; }
        public bool Procesada { get; set; }

        public virtual Compras_pedidos_detalle Pedido_numero_lineaNavigation { get; set; }
        public virtual Almacen Picking_almacenNavigation { get; set; }
    }
}
