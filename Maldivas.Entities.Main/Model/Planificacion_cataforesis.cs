using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Planificacion_cataforesis
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public DateTime? Fecha_inicial { get; set; }
        public DateTime? Fecha_final { get; set; }
        public int Cantidad { get; set; }
        public int Lote_entrega { get; set; }
        public int Unidades_jaula { get; set; }
        public int Orden { get; set; }
        public int? Pedido { get; set; }
        public string Proveedor { get; set; }
        public string Pedido_codigo { get; set; }
        public string Pedido_ejercicio { get; set; }
        public string Pedido_modo { get; set; }
        public int? Pedido_numero { get; set; }
        public int Pedidas { get; set; }
        public int Servidas { get; set; }
        public int Pendientes { get; set; }
    }
}
