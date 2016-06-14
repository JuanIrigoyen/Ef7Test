using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Piezas
    {
        public Piezas()
        {
            Componentes = new HashSet<Componentes>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Componentes> Componentes { get; set; }
    }
}
