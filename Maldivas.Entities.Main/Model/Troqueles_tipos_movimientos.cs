using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_tipos_movimientos
    {
        public Troqueles_tipos_movimientos()
        {
            Troqueles_movimientos = new HashSet<Troqueles_movimientos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Troqueles_movimientos> Troqueles_movimientos { get; set; }
    }
}
