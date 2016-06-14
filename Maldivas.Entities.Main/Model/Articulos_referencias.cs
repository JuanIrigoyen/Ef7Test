using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_referencias
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Referencia { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
    }
}
