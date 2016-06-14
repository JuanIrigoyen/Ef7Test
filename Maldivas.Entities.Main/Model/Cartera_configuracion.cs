using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Cartera_configuracion
    {
        public int Codigo { get; set; }
        public int Cartera_ventas_bolsa_codigo { get; set; }
        public int Cartera_compras_bolsa_codigo { get; set; }
    }
}
