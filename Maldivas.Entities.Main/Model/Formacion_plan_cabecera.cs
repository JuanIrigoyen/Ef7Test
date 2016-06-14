using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_plan_cabecera
    {
        public int Codigo { get; set; }
        public string Ejercicio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Departamento { get; set; }
        public DateTime? Fecha_aprobacion { get; set; }
    }
}
