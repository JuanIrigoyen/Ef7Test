using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_graficos
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public int Numero { get; set; }
        public byte[] Imagen { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
