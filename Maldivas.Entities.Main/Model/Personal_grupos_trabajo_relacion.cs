using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_grupos_trabajo_relacion
    {
        public int Codigo { get; set; }
        public string Grupo_trabajo { get; set; }
        public string Personal { get; set; }

        public virtual Personal_grupos_trabajo Grupo_trabajoNavigation { get; set; }
        public virtual Personal PersonalNavigation { get; set; }
    }
}
