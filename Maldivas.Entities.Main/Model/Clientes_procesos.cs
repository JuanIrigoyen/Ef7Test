using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_procesos
    {
        public string Cliente { get; set; }
        public string Proceso { get; set; }
        public bool? Activo { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Procesos_tipos ProcesoNavigation { get; set; }
    }
}
