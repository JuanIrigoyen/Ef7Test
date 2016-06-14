using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_almacen_ubicacion_predeterminada
    {
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }

        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
