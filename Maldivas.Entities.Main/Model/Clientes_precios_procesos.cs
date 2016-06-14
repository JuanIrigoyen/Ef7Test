using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_precios_procesos
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Operacion { get; set; }
        public int? Filas { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
