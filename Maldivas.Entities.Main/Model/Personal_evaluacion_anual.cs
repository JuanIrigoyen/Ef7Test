using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_evaluacion_anual
    {
        public int Codaux { get; set; }
        public string Codigo { get; set; }
        public string Ejercicio { get; set; }
        public byte? Valoracion { get; set; }
        public string Indicador { get; set; }
        public string Observaciones { get; set; }
    }
}
