using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_graficos
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public byte[] Grafico { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
    }
}
