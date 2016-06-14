using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_procesos
    {
        public string Proveedor { get; set; }
        public string Proceso { get; set; }
        public bool? Activo { get; set; }

        public virtual Procesos_tipos ProcesoNavigation { get; set; }
    }
}
