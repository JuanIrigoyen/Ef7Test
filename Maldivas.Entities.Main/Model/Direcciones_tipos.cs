using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Direcciones_tipos
    {
        public Direcciones_tipos()
        {
            Clientes_direcciones = new HashSet<Clientes_direcciones>();
            Proveedores_direcciones = new HashSet<Proveedores_direcciones>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Clientes_direcciones> Clientes_direcciones { get; set; }
        public virtual ICollection<Proveedores_direcciones> Proveedores_direcciones { get; set; }
    }
}
