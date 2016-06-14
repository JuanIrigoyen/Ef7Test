using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_evaluacion
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public byte PRL { get; set; }
        public byte Iniciativa { get; set; }
        public byte Aptitud { get; set; }
        public byte Equipo { get; set; }
        public byte Conocimientos { get; set; }
        public byte Actitud { get; set; }
        public byte Productividad { get; set; }
        public string Observaciones { get; set; }
    }
}
