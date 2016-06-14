using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_solicitudes
    {
        public int Ind { get; set; }
        public DateTime? Fecha_solicitud { get; set; }
        public DateTime? Hora { get; set; }
        public string Seccion { get; set; }
        public string Maquina { get; set; }
        public bool? Marcha { get; set; }
        public string Tipo_averia { get; set; }
        public string Descripcion_averia { get; set; }
        public string Solicitante { get; set; }
        public string Responsable { get; set; }
        public string Prioridad { get; set; }
        public DateTime? Fecha_propuesta { get; set; }
        public int? Orden_trabajo { get; set; }
        public bool Aceptado { get; set; }
        public string Observaciones { get; set; }
    }
}
