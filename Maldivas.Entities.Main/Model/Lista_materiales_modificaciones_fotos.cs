using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Lista_materiales_modificaciones_fotos
    {
        public int Codigo { get; set; }
        public int? Modificacion { get; set; }
        public byte[] Foto { get; set; }
    }
}
