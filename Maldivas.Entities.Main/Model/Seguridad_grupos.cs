using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Seguridad_grupos
    {
        public Seguridad_grupos()
        {
            Seguridad_conceptos = new HashSet<Seguridad_conceptos>();
        }

        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Seguridad_conceptos> Seguridad_conceptos { get; set; }
    }
}
