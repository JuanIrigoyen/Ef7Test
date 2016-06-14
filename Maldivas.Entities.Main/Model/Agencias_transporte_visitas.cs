using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_visitas
    {
        public string Agencia { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }

        public virtual Agencias_transporte AgenciaNavigation { get; set; }
    }
}
