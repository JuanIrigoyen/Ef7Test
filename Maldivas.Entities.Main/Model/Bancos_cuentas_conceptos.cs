using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos_cuentas_conceptos
    {
        public Bancos_cuentas_conceptos()
        {
            Bancos_cuentas_configuracion = new HashSet<Bancos_cuentas_configuracion>();
        }

        public int Codigo { get; set; }
        public string Concepto { get; set; }

        public virtual ICollection<Bancos_cuentas_configuracion> Bancos_cuentas_configuracion { get; set; }
    }
}
