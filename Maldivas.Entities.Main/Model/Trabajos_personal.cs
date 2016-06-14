using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Trabajos_personal
    {
        public int Trabajo { get; set; }
        public string Personal { get; set; }
        public int Orden_trabajo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public DateTime? Fecha_transaccion { get; set; }
        public string Observaciones { get; set; }
    }
}
