using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_objetivos
    {
        public string Cliente { get; set; }
        public string Ejercicio { get; set; }
        public int Codaux { get; set; }
        public decimal Prevision { get; set; }
        public decimal Objetivo { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
    }
}
