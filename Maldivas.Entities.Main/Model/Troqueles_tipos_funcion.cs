using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_tipos_funcion
    {
        public Troqueles_tipos_funcion()
        {
            Troqueles = new HashSet<Troqueles>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Troqueles> Troqueles { get; set; }
    }
}
