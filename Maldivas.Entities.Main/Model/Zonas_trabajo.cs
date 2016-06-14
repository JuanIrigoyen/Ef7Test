using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Zonas_trabajo
    {
        public Zonas_trabajo()
        {
            Zona_seccion = new HashSet<Zona_seccion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Zona_seccion> Zona_seccion { get; set; }
    }
}
