using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Calendarios
    {
        public Calendarios()
        {
            Calendarios_configuracion = new HashSet<Calendarios_configuracion>();
        }

        public int Calendario { get; set; }
        public string Descripcion { get; set; }
        public string Ejercicio { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Calendarios_configuracion> Calendarios_configuracion { get; set; }
    }
}
