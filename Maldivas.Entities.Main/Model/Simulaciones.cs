using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Simulaciones
    {
        public Simulaciones()
        {
            Ordenes_trabajo = new HashSet<Ordenes_trabajo>();
        }

        public int Simulacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Ordenes_trabajo> Ordenes_trabajo { get; set; }
    }
}
