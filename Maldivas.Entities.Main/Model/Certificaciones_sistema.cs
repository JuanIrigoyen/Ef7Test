using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Certificaciones_sistema
    {
        public Certificaciones_sistema()
        {
            Proveedores_certificaciones = new HashSet<Proveedores_certificaciones>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Proveedores_certificaciones> Proveedores_certificaciones { get; set; }
    }
}
