using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Tipo_cargas
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Volumen { get; set; }
        public decimal Tiempo { get; set; }
    }
}
