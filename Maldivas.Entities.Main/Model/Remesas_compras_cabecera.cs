using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Remesas_compras_cabecera
    {
        public Remesas_compras_cabecera()
        {
            Remesas_compras = new HashSet<Remesas_compras>();
            Remesas_compras_detalle = new HashSet<Remesas_compras_detalle>();
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
        public bool Confirming_pronto_pago { get; set; }
        public bool Aprobada { get; set; }
        public bool Enviada { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Remesas_compras> Remesas_compras { get; set; }
        public virtual ICollection<Remesas_compras_detalle> Remesas_compras_detalle { get; set; }
    }
}
