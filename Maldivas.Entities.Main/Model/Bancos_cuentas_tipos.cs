using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos_cuentas_tipos
    {
        public Bancos_cuentas_tipos()
        {
            Bancos_cuentas = new HashSet<Bancos_cuentas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Bancos_cuentas> Bancos_cuentas { get; set; }
    }
}
