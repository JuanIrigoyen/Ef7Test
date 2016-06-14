using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_proformas_totales
    {
        public int Codigo { get; set; }
        public int? Proforma { get; set; }
        public int? Formula { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Total { get; set; }
    }
}
