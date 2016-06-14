using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_costes_maquinas
    {
        public string Centro { get; set; }
        public string Maquina { get; set; }

        public virtual Centros_costes CentroNavigation { get; set; }
    }
}
