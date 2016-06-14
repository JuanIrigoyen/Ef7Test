using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_articulos_proveedores
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Troquel { get; set; }
        public string Identificacion { get; set; }
        public DateTime? Fecha_compra { get; set; }
        public string Interlocutor { get; set; }
        public decimal Coste { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
