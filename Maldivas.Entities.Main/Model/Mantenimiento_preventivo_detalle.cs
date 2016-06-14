using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_preventivo_detalle
    {
        public int Codigo { get; set; }
        public string Preventivo { get; set; }
        public string Fase { get; set; }
        public string Descripcion { get; set; }
        public int Horas_maquina { get; set; }
        public string Periodicidad { get; set; }
    }
}
