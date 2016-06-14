using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Zona_seccion
    {
        public Zona_seccion()
        {
            Zonas_centros = new HashSet<Zonas_centros>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Zona { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Zonas_centros> Zonas_centros { get; set; }
        public virtual Zonas_trabajo ZonaNavigation { get; set; }
    }
}
