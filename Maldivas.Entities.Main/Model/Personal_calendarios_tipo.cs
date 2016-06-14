using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_calendarios_tipo
    {
        public Personal_calendarios_tipo()
        {
            Personal_calendarios = new HashSet<Personal_calendarios>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_calendarios> Personal_calendarios { get; set; }
    }
}
