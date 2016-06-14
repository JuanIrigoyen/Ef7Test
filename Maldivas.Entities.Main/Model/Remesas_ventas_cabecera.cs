using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Remesas_ventas_cabecera
    {
        public Remesas_ventas_cabecera()
        {
            Remesas_ventas = new HashSet<Remesas_ventas>();
            Remesas_ventas_detalle = new HashSet<Remesas_ventas_detalle>();
            Remesas_ventas_sepa = new HashSet<Remesas_ventas_sepa>();
        }

        public int Codigo { get; set; }
        public string Remesa { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Serie { get; set; }
        public int? Asiento { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha_remesa { get; set; }
        public DateTime? Fecha_envio { get; set; }
        public string Banco_nombre { get; set; }
        public string Banco_entidad { get; set; }
        public string Banco_agencia { get; set; }
        public string Banco_dc { get; set; }
        public string Banco_cuenta { get; set; }
        public string Banco_subcuenta { get; set; }
        public string Banco_sufijo { get; set; }
        public decimal Total_remesa { get; set; }
        public bool Aprobada { get; set; }
        public bool Enviada { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Remesas_ventas> Remesas_ventas { get; set; }
        public virtual ICollection<Remesas_ventas_detalle> Remesas_ventas_detalle { get; set; }
        public virtual ICollection<Remesas_ventas_sepa> Remesas_ventas_sepa { get; set; }
    }
}
