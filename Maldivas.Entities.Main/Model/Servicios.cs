using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Servicios
    {
        public int Codigo { get; set; }
        public string Metodo { get; set; }
        public string Descripcion { get; set; }
        public long Tiempo_proceso { get; set; }
        public DateTime? Fecha_ultima_ejecucion { get; set; }
        public string Error { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
    }
}
