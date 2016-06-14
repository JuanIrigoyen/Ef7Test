using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Embalajes_cajas_tipos
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Alto { get; set; }
    }
}
