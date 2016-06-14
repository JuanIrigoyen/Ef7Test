using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_presupuestos_prevision
    {
        public int Codigo { get; set; }
        public string Proveedor { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_prevista { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }
        public byte Tipo { get; set; }
        public string Banco_pago_subcuenta { get; set; }
        public int? Factura { get; set; }

        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
