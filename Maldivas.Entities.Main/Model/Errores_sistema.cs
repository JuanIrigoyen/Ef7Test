using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Errores_sistema
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Destinatarios { get; set; }
        public int? Error_number { get; set; }
        public int? Error_severity { get; set; }
        public int? Error_state { get; set; }
        public string Error_procedure { get; set; }
        public int? Error_line { get; set; }
        public string Error_message { get; set; }
    }
}
