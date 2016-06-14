using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Jaulas
    {
        public Jaulas()
        {
            Jaulas_movimientos = new HashSet<Jaulas_movimientos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Jaulas_movimientos> Jaulas_movimientos { get; set; }
        public virtual Utiles_jaulas TipoNavigation { get; set; }
    }
}
