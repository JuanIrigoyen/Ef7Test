using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proyectos
    {
        public int Codigo { get; set; }
        public string Proyecto { get; set; }
        public string Ejercicio { get; set; }
        public string Descripcion { get; set; }
        public string Cliente { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public DateTime? Fecha_final_prevista { get; set; }
        public decimal Valoracion_inicial { get; set; }
        public decimal Presupuesto { get; set; }
        public decimal Coste { get; set; }
        public string Observaciones { get; set; }
    }
}
