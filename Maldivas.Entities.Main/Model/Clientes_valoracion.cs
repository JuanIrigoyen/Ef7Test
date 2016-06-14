using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_valoracion
    {
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Rentabilidad { get; set; }
        public decimal Facturacion { get; set; }
        public decimal Impagados { get; set; }
        public decimal Abonos { get; set; }
        public int Valoracion { get; set; }
    }
}
