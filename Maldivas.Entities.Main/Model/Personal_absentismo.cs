using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_absentismo
    {
        public int Codigo { get; set; }
        public string Personal { get; set; }
        public string Ejercicio { get; set; }
        public string Mes { get; set; }
        public short Horas_posibles { get; set; }
        public short Horas_baja_enfermedad { get; set; }
        public short Horas_baja_accidente { get; set; }

        public virtual Personal PersonalNavigation { get; set; }
    }
}
