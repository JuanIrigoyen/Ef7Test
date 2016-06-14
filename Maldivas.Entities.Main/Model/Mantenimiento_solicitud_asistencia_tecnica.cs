using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_solicitud_asistencia_tecnica
    {
        public int Iden { get; set; }
        public string Empresa_externa { get; set; }
        public DateTime? Fecha_intervencion { get; set; }
        public string Maquina_instalacion { get; set; }
        public string Numero_documento { get; set; }
        public string Operario { get; set; }
        public int Horas { get; set; }
        public int Coste { get; set; }
        public string Observaciones { get; set; }
    }
}
