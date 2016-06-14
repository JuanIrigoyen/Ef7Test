using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Maquinas_centros_trabajo_relacion
    {
        public int Codigo { get; set; }
        public string Centro { get; set; }
        public string Maquina { get; set; }

        public virtual Centros_trabajo CentroNavigation { get; set; }
    }
}
