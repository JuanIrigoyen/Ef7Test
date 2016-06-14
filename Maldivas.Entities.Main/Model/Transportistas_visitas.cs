using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Transportistas_visitas
    {
        public string Transportista { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }

        public virtual Transportistas TransportistaNavigation { get; set; }
    }
}
