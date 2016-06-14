using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_chapa_forma
    {
        public Articulos_chapa_forma()
        {
            Articulos = new HashSet<Articulos>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos> Articulos { get; set; }
    }
}
