using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_visitas
    {
        public string Cliente { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
    }
}
