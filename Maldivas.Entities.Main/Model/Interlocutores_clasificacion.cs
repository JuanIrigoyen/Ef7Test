using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Interlocutores_clasificacion
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }
    }
}
