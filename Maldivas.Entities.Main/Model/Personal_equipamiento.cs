using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_equipamiento
    {
        public Personal_equipamiento()
        {
            Personal_equipamiento_movimientos = new HashSet<Personal_equipamiento_movimientos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_equipamiento_movimientos> Personal_equipamiento_movimientos { get; set; }
    }
}
