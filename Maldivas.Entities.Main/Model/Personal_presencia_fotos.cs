using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_presencia_fotos
    {
        public int Numero { get; set; }
        public int Codigo { get; set; }
        public byte[] Foto { get; set; }

        public virtual Personal_presencia CodigoNavigation { get; set; }
    }
}
