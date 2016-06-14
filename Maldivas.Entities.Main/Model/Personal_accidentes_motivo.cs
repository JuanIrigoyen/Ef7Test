using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_accidentes_motivo
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public bool Usado { get; set; }
        public string Observaciones { get; set; }
    }
}
