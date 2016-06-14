using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Estadisticas_usuarios
    {
        public int Estadistica { get; set; }
        public string Usuario { get; set; }

        public virtual Estadisticas EstadisticaNavigation { get; set; }
    }
}
