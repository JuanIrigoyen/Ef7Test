using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Calendarios_tipos
    {
        public Calendarios_tipos()
        {
            Calendarios_configuracion = new HashSet<Calendarios_configuracion>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Color { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Calendarios_configuracion> Calendarios_configuracion { get; set; }
    }
}
