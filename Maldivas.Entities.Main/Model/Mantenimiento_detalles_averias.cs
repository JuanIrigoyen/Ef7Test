using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_detalles_averias
    {
        public int Ind { get; set; }
        public DateTime? Fecha_averia { get; set; }
        public string Operario { get; set; }
        public string Equipo_instalacion { get; set; }
        public string Titulo_averia { get; set; }
        public string Detalle_averia { get; set; }
    }
}
