using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos_cuentas_configuracion
    {
        public string Cuenta { get; set; }
        public int Concepto { get; set; }
        public decimal Valor_porcentual { get; set; }
        public decimal Valor_monetario { get; set; }

        public virtual Bancos_cuentas_conceptos ConceptoNavigation { get; set; }
    }
}
