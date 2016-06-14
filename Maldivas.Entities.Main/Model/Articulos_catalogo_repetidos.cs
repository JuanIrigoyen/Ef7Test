using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_catalogo_repetidos
    {
        public string Articulo { get; set; }
        public string Subfamilia { get; set; }
        public int Orden_catalogo { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
