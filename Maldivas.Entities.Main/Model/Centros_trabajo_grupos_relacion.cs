using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_trabajo_grupos_relacion
    {
        public int Codigo { get; set; }
        public string Centro_trabajo { get; set; }
        public string Grupo_trabajo { get; set; }
        public short Orden { get; set; }

        public virtual Centros_trabajo Centro_trabajoNavigation { get; set; }
        public virtual Centros_trabajo_grupos Grupo_trabajoNavigation { get; set; }
    }
}
