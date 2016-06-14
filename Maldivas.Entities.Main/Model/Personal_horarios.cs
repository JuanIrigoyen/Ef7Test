using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_horarios
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Hora_desde { get; set; }
        public DateTime? Hora_hasta { get; set; }
        public string Observaciones { get; set; }
    }
}
