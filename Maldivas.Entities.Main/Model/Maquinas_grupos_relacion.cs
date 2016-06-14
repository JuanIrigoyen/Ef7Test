using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Maquinas_grupos_relacion
    {
        public int Codigo { get; set; }
        public string Maquina { get; set; }
        public string Grupo { get; set; }

        public virtual Maquinas MaquinaNavigation { get; set; }
    }
}
