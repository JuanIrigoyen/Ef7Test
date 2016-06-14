using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_clasificacion_relacion
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Departamento { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Articulos_clasificacion DepartamentoNavigation { get; set; }
    }
}
