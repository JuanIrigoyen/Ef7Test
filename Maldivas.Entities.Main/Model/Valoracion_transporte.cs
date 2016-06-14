using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Valoracion_transporte
    {
        public Valoracion_transporte()
        {
            Transportistas_evaluacion = new HashSet<Transportistas_evaluacion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Transportistas_evaluacion> Transportistas_evaluacion { get; set; }
    }
}
