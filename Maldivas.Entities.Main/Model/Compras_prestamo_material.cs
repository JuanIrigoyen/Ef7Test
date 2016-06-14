using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_prestamo_material
    {
        public int Codigo { get; set; }
        public string Operario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Observaciones { get; set; }
        public bool? Prestamo { get; set; }
        public bool? Devolucion { get; set; }
    }
}
