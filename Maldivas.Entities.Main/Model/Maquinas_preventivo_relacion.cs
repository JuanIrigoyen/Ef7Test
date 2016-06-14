using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Maquinas_preventivo_relacion
    {
        public string Preventivo { get; set; }
        public string Maquina { get; set; }

        public virtual Maquinas MaquinaNavigation { get; set; }
    }
}
