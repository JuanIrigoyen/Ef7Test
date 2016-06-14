using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_internet_grupos
    {
        public Clientes_internet_grupos()
        {
            Clientes_internet_seguridad_claves = new HashSet<Clientes_internet_seguridad_claves>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Clientes_internet_seguridad_claves> Clientes_internet_seguridad_claves { get; set; }
    }
}
