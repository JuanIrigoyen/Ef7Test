using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_lotes_tipos
    {
        public Articulos_lotes_tipos()
        {
            Articulos_lotes = new HashSet<Articulos_lotes>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_lotes> Articulos_lotes { get; set; }
    }
}
