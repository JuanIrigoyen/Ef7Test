using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Documentacion_grupos
    {
        public Documentacion_grupos()
        {
            Documentacion_conceptos = new HashSet<Documentacion_conceptos>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Documentacion_conceptos> Documentacion_conceptos { get; set; }
    }
}
