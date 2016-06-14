using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_stocks
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int? Lote { get; set; }
        public int Existencias { get; set; }
        public int Reservado { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fecha_ultimo_inventario { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Almacen_ubicaciones Almacen_ubicaciones { get; set; }
    }
}
