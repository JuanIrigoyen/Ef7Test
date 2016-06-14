using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_calendarios
    {
        public int Codigo { get; set; }
        public string Personal { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tipo_dia { get; set; }
        public string Horario { get; set; }
        public string Centro { get; set; }

        public virtual Personal PersonalNavigation { get; set; }
        public virtual Personal_calendarios_tipo Tipo_diaNavigation { get; set; }
    }
}
