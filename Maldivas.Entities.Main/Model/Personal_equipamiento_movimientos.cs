using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_equipamiento_movimientos
    {
        public int Codigo { get; set; }
        public string Personal { get; set; }
        public string Epis { get; set; }
        public short Unidades { get; set; }
        public DateTime? Fecha_entrega { get; set; }
        public DateTime? Fecha_sistema { get; set; }
        public string Observaciones { get; set; }

        public virtual Personal_equipamiento EpisNavigation { get; set; }
        public virtual Personal PersonalNavigation { get; set; }
    }
}
