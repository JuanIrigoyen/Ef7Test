using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Rutas_planificadas
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_mensaje { get; set; }
        public DateTime? Fecha_limite { get; set; }
        public DateTime? Fecha_mercancia { get; set; }
        public byte? Calendario { get; set; }
        public short Periodo_ciclo_dias { get; set; }
        public short Periodo_ciclo_semanas { get; set; }
        public short Frecuencia { get; set; }
        public short Dia { get; set; }
        public short Dia_ciclo_meses { get; set; }
        public byte Primero { get; set; }
        public byte Primer_dia_semana { get; set; }
        public byte Primera_semana_meses { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public string Observaciones { get; set; }
    }
}
