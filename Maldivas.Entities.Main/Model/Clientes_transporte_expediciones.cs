using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_transporte_expediciones
    {
        public string Agencia { get; set; }
        public string Cliente { get; set; }
        public bool Reexpedicion { get; set; }

        public virtual Agencias_transporte AgenciaNavigation { get; set; }
    }
}
