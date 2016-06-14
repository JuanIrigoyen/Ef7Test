using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Competidores_visitas
    {
        public string Competidor { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }

        public virtual Competidores CompetidorNavigation { get; set; }
    }
}
