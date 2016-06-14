using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Etiquetas_registro
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public int Rango { get; set; }
        public int? Numero { get; set; }

        public virtual Compras_pedidos_detalle NumeroNavigation { get; set; }
        public virtual Etiquetas_rangos RangoNavigation { get; set; }
    }
}
