using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Componentes
    {
        public int Codigo { get; set; }
        public string Pieza { get; set; }
        public string Componente { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual Piezas PiezaNavigation { get; set; }
    }
}
