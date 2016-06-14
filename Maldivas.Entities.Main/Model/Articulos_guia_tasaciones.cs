using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_guia_tasaciones
    {
        public int Codaux { get; set; }
        public string Articulo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public decimal Precio { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
