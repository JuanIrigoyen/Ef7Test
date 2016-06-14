using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_stocks_configuracion
    {
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public string Articulo_configuracion { get; set; }
        public int Existencias { get; set; }
        public int Stock_minimo { get; set; }
        public int Stock_seguridad { get; set; }
        public int Lote_entrega { get; set; }
        public int Lote_diferido { get; set; }
        public int Punto_pedido { get; set; }
        public int Lanzamiento_propuesta { get; set; }
        public int Lanzamiento_entrega { get; set; }
        public int Lanzamiento_pedido { get; set; }

        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
