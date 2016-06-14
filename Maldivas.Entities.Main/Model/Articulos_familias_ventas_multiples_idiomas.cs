using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_familias_ventas_multiples_idiomas
    {
        public string Articulo { get; set; }
        public string Subfamilia { get; set; }
        public string Idioma { get; set; }
        public string Descripcion { get; set; }

        public virtual Articulos_familias_ventas_multiples Articulos_familias_ventas_multiples { get; set; }
    }
}
