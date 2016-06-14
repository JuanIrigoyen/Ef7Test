using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_riesgos
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Credito_caucion { get; set; }
        public decimal Importe_anterior { get; set; }
        public decimal Importe_actual { get; set; }
        public DateTime? Fecha { get; set; }
        public string Observaciones { get; set; }
    }
}
