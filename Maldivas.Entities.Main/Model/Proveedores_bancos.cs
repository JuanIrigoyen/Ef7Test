using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_bancos
    {
        public int Codigo { get; set; }
        public string Proveedor { get; set; }
        public string Tipo { get; set; }
        public string Entidad { get; set; }
        public string Agencia { get; set; }
        public string Dc { get; set; }
        public string Cuenta { get; set; }
        public string Subcuenta { get; set; }
        public string Sufijo { get; set; }
        public string Observaciones { get; set; }
        public string Swift { get; set; }
        public string Iban { get; set; }

        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
