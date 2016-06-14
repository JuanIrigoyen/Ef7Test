using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Cartera_estados
    {
        public byte Codigo { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public byte? Tipo { get; set; }
        public string Observaciones { get; set; }
    }
}
