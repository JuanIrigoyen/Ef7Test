using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_movimientos_tipos
    {
        public Articulos_movimientos_tipos()
        {
            Articulos_movimientos = new HashSet<Articulos_movimientos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_movimientos> Articulos_movimientos { get; set; }
    }
}
