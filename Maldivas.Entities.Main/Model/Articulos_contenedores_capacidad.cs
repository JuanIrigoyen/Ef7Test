using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_contenedores_capacidad
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Contenedor_tipo { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Contenedores_tipos Contenedor_tipoNavigation { get; set; }
    }
}
