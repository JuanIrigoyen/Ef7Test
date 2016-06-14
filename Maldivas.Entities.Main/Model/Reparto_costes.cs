using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Reparto_costes
    {
        public int Codigo { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public string Factura_ejercicio { get; set; }
        public string Factura_modo { get; set; }
        public string Proveedor { get; set; }
        public string Asignacion { get; set; }
        public string Cuenta { get; set; }
        public DateTime? Fecha { get; set; }
        public string Area { get; set; }
        public string Seccion { get; set; }
        public string Centro_coste { get; set; }
        public string Ot { get; set; }
        public decimal Importe { get; set; }
        public int? Asiento { get; set; }
        public string Documento { get; set; }
        public string Observaciones { get; set; }
    }
}
