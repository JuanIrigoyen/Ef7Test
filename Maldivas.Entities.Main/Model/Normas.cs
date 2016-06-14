using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Normas
    {
        public Normas()
        {
            Articulos_chapa_calidad = new HashSet<Articulos_chapa_calidad>();
        }

        public string Codigo { get; set; }
        public string Norma { get; set; }

        public virtual ICollection<Articulos_chapa_calidad> Articulos_chapa_calidad { get; set; }
    }
}
