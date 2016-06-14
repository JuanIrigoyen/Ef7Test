using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_referencias_produccion
    {
        public string Articulo { get; set; }
        public string Referencia_auxiliar { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
