using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Anticipos
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Ejercicio { get; set; }
        public string Personal { get; set; }
        public string Subcuenta_personal { get; set; }
        public string Subcuenta_gastos { get; set; }
        public string Divisa { get; set; }
        public DateTime? Fecha_anticipo { get; set; }
        public DateTime? Fecha_devolucion { get; set; }
        public DateTime? Fecha_creacion { get; set; }
        public string Concepto { get; set; }
        public decimal Importe_anticipo { get; set; }
        public decimal Importe_gastado { get; set; }
        public decimal Diferencia { get; set; }
        public bool Completado { get; set; }
        public decimal Saldo { get; set; }
        public string Observaciones { get; set; }

        public virtual Personal PersonalNavigation { get; set; }
    }
}
