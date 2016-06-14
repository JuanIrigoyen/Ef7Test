using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_cuentas_contables
    {
        public string Proveedor { get; set; }
        public string Tipo { get; set; }
        public string Cuenta { get; set; }

        public virtual Cuentas_contables_tipos TipoNavigation { get; set; }
    }
}
