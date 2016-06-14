using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos_cuentas_divisas_tipos
    {
        public Bancos_cuentas_divisas_tipos()
        {
            Bancos_cuentas_divisas_apuntes = new HashSet<Bancos_cuentas_divisas_apuntes>();
        }

        public string Cuenta { get; set; }
        public int Codaux { get; set; }
        public string Divisa { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Bancos_cuentas_divisas_apuntes> Bancos_cuentas_divisas_apuntes { get; set; }
    }
}
