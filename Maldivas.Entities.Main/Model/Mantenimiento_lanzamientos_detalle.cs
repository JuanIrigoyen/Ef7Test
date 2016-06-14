using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_lanzamientos_detalle
    {
        public int Clave { get; set; }
        public int? Iden { get; set; }
        public int? Fase { get; set; }
        public string Descripcion_fase { get; set; }
        public decimal? Horas { get; set; }
        public bool? Realizado { get; set; }
        public DateTime? Fecha_lanzamiento { get; set; }
        public int? Gama { get; set; }
    }
}
