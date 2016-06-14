using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Fases
    {
        public Fases()
        {
            Articulos_fases = new HashSet<Articulos_fases>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo_fase { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_fases> Articulos_fases { get; set; }
    }
}
