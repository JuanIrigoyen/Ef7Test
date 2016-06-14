using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Talleres_visitas
    {
        public string Taller { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }

        public virtual Talleres TallerNavigation { get; set; }
    }
}
