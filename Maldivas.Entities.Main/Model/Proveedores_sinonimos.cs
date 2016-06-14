using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_sinonimos
    {
        public string Proveedor { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
