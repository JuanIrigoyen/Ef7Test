using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_albaranes_entradas_log
    {
        public int Codigo { get; set; }
        public string Operario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Articulo { get; set; }
        public string Tracking { get; set; }
    }
}
