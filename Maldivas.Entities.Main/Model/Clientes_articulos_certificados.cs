﻿using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_articulos_certificados
    {
        public string Cliente { get; set; }
        public string Articulo { get; set; }
        public string Certificacion { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
    }
}