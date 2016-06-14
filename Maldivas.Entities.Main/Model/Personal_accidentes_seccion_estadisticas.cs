using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_accidentes_seccion_estadisticas
    {
        public int Ind { get; set; }
        public int? Ejercicio { get; set; }
        public short? Trimestre { get; set; }
        public int? Codigo_Seccion { get; set; }
        public int Numero_Accidentes_Baja { get; set; }
        public int Numero_Accidentes_NoBaja { get; set; }
    }
}
