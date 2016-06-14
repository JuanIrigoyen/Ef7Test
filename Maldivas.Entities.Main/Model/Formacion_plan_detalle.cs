using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_plan_detalle
    {
        public int Codigo { get; set; }
        public int Cabecera { get; set; }
        public string Curso { get; set; }
        public bool Aprobado { get; set; }
        public string Observaciones { get; set; }
    }
}
