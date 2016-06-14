using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Utiles_jaulas
    {
        public Utiles_jaulas()
        {
            Jaulas = new HashSet<Jaulas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Codigo_barras { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Jaulas> Jaulas { get; set; }
    }
}
