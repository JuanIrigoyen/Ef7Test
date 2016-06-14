using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Almacen_ubicaciones
    {
        public Almacen_ubicaciones()
        {
            Articulos_movimientos = new HashSet<Articulos_movimientos>();
            Articulos_stocks = new HashSet<Articulos_stocks>();
        }

        public string Almacen { get; set; }
        public string Ubicacion { get; set; }

        public virtual ICollection<Articulos_movimientos> Articulos_movimientos { get; set; }
        public virtual ICollection<Articulos_stocks> Articulos_stocks { get; set; }
        public virtual Almacen AlmacenNavigation { get; set; }
    }
}
