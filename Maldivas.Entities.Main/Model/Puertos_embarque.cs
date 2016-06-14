using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Puertos_embarque
    {
        public Puertos_embarque()
        {
            Incoterms = new HashSet<Incoterms>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Incoterms> Incoterms { get; set; }
    }
}
