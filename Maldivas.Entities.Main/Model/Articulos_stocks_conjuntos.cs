using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_stocks_conjuntos
    {
        public string Padre { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }

        public virtual Articulos PadreNavigation { get; set; }
    }
}
