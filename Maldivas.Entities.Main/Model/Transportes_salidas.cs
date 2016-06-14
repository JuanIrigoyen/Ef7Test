using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Transportes_salidas
    {
        public int Codigo { get; set; }
        public string Matricula { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Total { get; set; }
        public int? Salida { get; set; }
        public bool Verificada { get; set; }
        public string Observaciones { get; set; }
    }
}
