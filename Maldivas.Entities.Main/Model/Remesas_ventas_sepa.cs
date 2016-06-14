using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Remesas_ventas_sepa
    {
        public int Numero { get; set; }
        public int? Linea { get; set; }
        public int? Remesa { get; set; }
        public string Remesa_bancaria { get; set; }

        public virtual Remesas_ventas_cabecera RemesaNavigation { get; set; }
    }
}
