using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_stocks_auditacion_configuracion
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Articulo_clasificacion { get; set; }
        public bool Auditar { get; set; }
    }
}
