using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_zonas
    {
        public string Agencia { get; set; }
        public string Zona_agencia { get; set; }
        public string Zona { get; set; }
        public string Tiempo { get; set; }
        public bool Optimo { get; set; }
        public string Observaciones { get; set; }

        public virtual Agencias_transporte AgenciaNavigation { get; set; }
        public virtual Clientes_zonas ZonaNavigation { get; set; }
    }
}
