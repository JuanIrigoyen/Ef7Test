using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Trabajos
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Orden_trabajo { get; set; }
        public string Centro_trabajo { get; set; }
        public string Centro_coste { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public long? Tiempo_total { get; set; }
        public DateTime? Fecha_ultima_modificacion { get; set; }
        public string Personal { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
    }
}
