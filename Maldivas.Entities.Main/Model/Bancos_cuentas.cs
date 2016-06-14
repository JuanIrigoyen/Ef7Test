using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos_cuentas
    {
        public int Codigo { get; set; }
        public string Entidad { get; set; }
        public string Cuenta { get; set; }
        public string Dc { get; set; }
        public string Tipo { get; set; }
        public string Subcuenta { get; set; }
        public string Divisa { get; set; }
        public decimal Interes { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public bool Activada { get; set; }

        public virtual Bancos EntidadNavigation { get; set; }
        public virtual Bancos_cuentas_tipos TipoNavigation { get; set; }
    }
}
