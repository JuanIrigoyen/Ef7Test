using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_graficos
    {
        public int Codigo { get; set; }
        public string Proveedor { get; set; }
        public byte[] Grafico { get; set; }

        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
