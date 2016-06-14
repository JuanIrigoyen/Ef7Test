using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Prioridades
    {
        public Prioridades()
        {
            Ordenes_trabajo = new HashSet<Ordenes_trabajo>();
        }

        public int Prioridad { get; set; }
        public string Descripcion { get; set; }
        public int Color { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Ordenes_trabajo> Ordenes_trabajo { get; set; }
    }
}
