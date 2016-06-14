using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_pedidos_baja_rentabilidad
    {
        public int Codigo { get; set; }
        public int? Pedido { get; set; }
        public string Pedido_codigo { get; set; }
        public string Cliente { get; set; }
        public decimal Rentabilidad { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Numero_piezas { get; set; }
        public decimal? Valor_piezas { get; set; }
    }
}
