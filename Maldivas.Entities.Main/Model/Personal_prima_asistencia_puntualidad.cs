using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_prima_asistencia_puntualidad
    {
        public Personal_prima_asistencia_puntualidad()
        {
            Personal = new HashSet<Personal>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
