using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Preparacion_previa_material_unidades
    {
        public int Codigo { get; set; }
        public DateTime? Planificacion_fecha { get; set; }
        public int? Pedido { get; set; }
        public string Pedido_codigo { get; set; }
        public string Pedido_ejercicio { get; set; }
        public string Pedido_modo { get; set; }
        public DateTime? Fecha_pedido { get; set; }
        public DateTime? Fecha_entrega { get; set; }
        public int? Pedido_numero_linea { get; set; }
        public string Cliente { get; set; }
        public string Cliente_empresa { get; set; }
        public string Jaula { get; set; }
        public string Articulo { get; set; }
        public int Cantidad_planificada { get; set; }
        public int Cantidad_preparada { get; set; }
        public bool Procesada { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_bruto { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Ventas_pedidos_cabecera PedidoNavigation { get; set; }
        public virtual Ventas_pedidos_detalle Pedido_numero_lineaNavigation { get; set; }
    }
}
