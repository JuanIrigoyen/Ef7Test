using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_embalajes
    {
        public string Articulo { get; set; }
        public string Embalaje { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Embalajes EmbalajeNavigation { get; set; }
    }
}
