using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Cuentas_contables_tipos
    {
        public Cuentas_contables_tipos()
        {
            Clientes_cuentas_contables = new HashSet<Clientes_cuentas_contables>();
            Proveedores_cuentas_contables = new HashSet<Proveedores_cuentas_contables>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Clientes_cuentas_contables> Clientes_cuentas_contables { get; set; }
        public virtual ICollection<Proveedores_cuentas_contables> Proveedores_cuentas_contables { get; set; }
    }
}
