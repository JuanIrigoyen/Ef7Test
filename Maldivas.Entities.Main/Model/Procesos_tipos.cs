using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Procesos_tipos
    {
        public Procesos_tipos()
        {
            Clientes_procesos = new HashSet<Clientes_procesos>();
            Proveedores_procesos = new HashSet<Proveedores_procesos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Clientes_procesos> Clientes_procesos { get; set; }
        public virtual ICollection<Proveedores_procesos> Proveedores_procesos { get; set; }
    }
}
