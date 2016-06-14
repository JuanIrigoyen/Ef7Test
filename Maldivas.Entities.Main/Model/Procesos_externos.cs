using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Procesos_externos
    {
        public int ProcesoId { get; set; }
        public string Descripcion { get; set; }
        public string Proceso { get; set; }
        public string ComputerName { get; set; }
        public DateTime? Fecha { get; set; }
        public byte Procesado { get; set; }
    }
}
