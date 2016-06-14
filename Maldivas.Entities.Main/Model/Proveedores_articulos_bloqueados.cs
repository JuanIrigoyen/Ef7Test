using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_articulos_bloqueados
    {
        public string Proveedor { get; set; }
        public string Articulo { get; set; }
        public int Codaux { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
