using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_imagenes
    {
        public int Codaux { get; set; }
        public string Codigo { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos CodigoNavigation { get; set; }
    }
}
