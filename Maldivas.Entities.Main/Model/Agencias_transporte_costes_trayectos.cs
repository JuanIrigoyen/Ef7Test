using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_costes_trayectos
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Trayecto { get; set; }
        public decimal Coste { get; set; }
        public bool Reexpedicion { get; set; }
        public string Observaciones { get; set; }
    }
}
