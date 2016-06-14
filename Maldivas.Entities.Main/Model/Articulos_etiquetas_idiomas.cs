using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_etiquetas_idiomas
    {
        public string Articulo { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Lenguajes IdiomaNavigation { get; set; }
    }
}
