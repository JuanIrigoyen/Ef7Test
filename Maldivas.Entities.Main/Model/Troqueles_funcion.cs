using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_funcion
    {
        public Troqueles_funcion()
        {
            Troqueles = new HashSet<Troqueles>();
            Utiles_soldar = new HashSet<Utiles_soldar>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Troqueles> Troqueles { get; set; }
        public virtual ICollection<Utiles_soldar> Utiles_soldar { get; set; }
    }
}
