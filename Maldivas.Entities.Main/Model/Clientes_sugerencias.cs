using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_sugerencias
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Sugerencia { get; set; }
        public DateTime? Sugerencia_fecha { get; set; }
        public string Respuesta { get; set; }
        public DateTime? Respuesta_fecha { get; set; }
    }
}
