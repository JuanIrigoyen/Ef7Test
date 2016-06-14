using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_albaranes_carga_operarios
    {
        public int Albaran { get; set; }
        public string Jaula { get; set; }
        public string Operario { get; set; }

        public virtual Ventas_albaranes_cabecera AlbaranNavigation { get; set; }
        public virtual Personal OperarioNavigation { get; set; }
    }
}
