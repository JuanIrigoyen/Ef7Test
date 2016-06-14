using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_empresas_historico
    {
        public string Codigo { get; set; }
        public string Empresa { get; set; }
        public string Personal { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public DateTime? Fecha_baja { get; set; }
        public string Observaciones { get; set; }
    }
}
