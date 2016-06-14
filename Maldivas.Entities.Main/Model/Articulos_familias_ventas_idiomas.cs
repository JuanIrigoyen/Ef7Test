using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_familias_ventas_idiomas
    {
        public int Familia { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }

        public virtual Articulos_familias_ventas FamiliaNavigation { get; set; }
        public virtual Lenguajes IdiomaNavigation { get; set; }
    }
}
