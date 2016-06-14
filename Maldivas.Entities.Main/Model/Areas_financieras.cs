using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Areas_financieras
    {
        public Areas_financieras()
        {
            Articulos_reparto_costes = new HashSet<Articulos_reparto_costes>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_reparto_costes> Articulos_reparto_costes { get; set; }
    }
}
