using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_facturas_periodos_cierre
    {
        public int Codigo { get; set; }
        public string Ejercicio { get; set; }
        public int Mes { get; set; }
        public bool Cierre { get; set; }
    }
}
