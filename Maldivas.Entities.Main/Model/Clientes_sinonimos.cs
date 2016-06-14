using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_sinonimos
    {
        public string Cliente { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
    }
}
