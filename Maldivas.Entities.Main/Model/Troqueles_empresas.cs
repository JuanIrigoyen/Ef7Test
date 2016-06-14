using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_empresas
    {
        public string Codigo_proveedor { get; set; }
        public string Codigo_troquel { get; set; }
        public int Porcentaje { get; set; }

        public virtual Proveedores Codigo_proveedorNavigation { get; set; }
        public virtual Troqueles Codigo_troquelNavigation { get; set; }
    }
}
