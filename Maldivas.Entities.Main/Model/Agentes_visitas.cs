using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agentes_visitas
    {
        public string Agente { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }

        public virtual Agentes AgenteNavigation { get; set; }
    }
}
