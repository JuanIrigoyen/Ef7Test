using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_articulos
    {
        public int Codigo { get; set; }
        public string Troquel { get; set; }
        public string Articulo { get; set; }

        public virtual Troqueles TroquelNavigation { get; set; }
    }
}
