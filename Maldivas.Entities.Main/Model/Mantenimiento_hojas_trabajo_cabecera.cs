using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_hojas_trabajo_cabecera
    {
        public int Ind { get; set; }
        public DateTime? Fecha_hoja { get; set; }
        public string Operario { get; set; }
        public string Observaciones { get; set; }
        public int Horas_ordinarias { get; set; }
        public int Horas_ordinarias_nocturnas { get; set; }
        public int Horas_ordinarias_festivas { get; set; }
        public int Horas_ordinarias_festivas_nocturnas { get; set; }
        public int Horas_extras { get; set; }
        public int Horas_extras_nocturnas { get; set; }
        public int Horas_extras_festivas { get; set; }
        public int Horas_extras_festivas_nocturnas { get; set; }
        public bool Traspasada { get; set; }
    }
}
