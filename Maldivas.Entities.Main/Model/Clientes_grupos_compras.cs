using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_grupos_compras
    {
        public Clientes_grupos_compras()
        {
            Clientes = new HashSet<Clientes>();
            Clientes_grupos_compras_rappels = new HashSet<Clientes_grupos_compras_rappels>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Clientes_grupos_compras_rappels> Clientes_grupos_compras_rappels { get; set; }
    }
}
