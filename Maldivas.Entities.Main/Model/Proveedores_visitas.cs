using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_visitas
    {
        public string Proveedor { get; set; }
        public DateTime Visita { get; set; }
        public string Observaciones { get; set; }
    }
}
