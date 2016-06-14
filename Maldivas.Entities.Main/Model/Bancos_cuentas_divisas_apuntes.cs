using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos_cuentas_divisas_apuntes
    {
        public int Codigo { get; set; }
        public string Ejercicio { get; set; }
        public string Cuenta { get; set; }
        public string Divisa { get; set; }
        public double Divisa_cambio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }

        public virtual Bancos_cuentas_divisas_tipos CuentaNavigation { get; set; }
    }
}
