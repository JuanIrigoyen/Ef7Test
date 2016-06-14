using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Jaulas_movimientos
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Jaula { get; set; }
        public DateTime Fecha { get; set; }
        public string Matricula { get; set; }
        public string Contenedor { get; set; }
        public string Observaciones { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Jaulas JaulaNavigation { get; set; }
    }
}
