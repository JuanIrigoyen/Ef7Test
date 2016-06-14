using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_calendarios_base_detalle
    {
        public int Codigo { get; set; }
        public string Calendario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tipo_dia { get; set; }
    }
}
