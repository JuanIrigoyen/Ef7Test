using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_cuentas_contables
    {
        public string Cliente { get; set; }
        public string Tipo { get; set; }
        public string Cuenta { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Cuentas_contables_tipos TipoNavigation { get; set; }
    }
}
