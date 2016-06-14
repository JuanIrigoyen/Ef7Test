using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Zonas_centros
    {
        public string Codigo { get; set; }
        public string Seccion { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual Zona_seccion SeccionNavigation { get; set; }
    }
}
