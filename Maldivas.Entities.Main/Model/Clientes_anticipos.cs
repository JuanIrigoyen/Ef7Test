using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_anticipos
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Ejercicio { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }
        public string Divisa { get; set; }
        public decimal Divisa_cambio_anticipo { get; set; }
        public decimal Divisa_cambio_cobro { get; set; }
        public decimal Diferencia_cambio { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public string Factura_ejercicio { get; set; }
        public string Factura_modo { get; set; }
        public string Banco_cobro_subcuenta { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
    }
}
