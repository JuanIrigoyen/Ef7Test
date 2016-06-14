using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_hojas_trabajo_detalle
    {
        public int Clave { get; set; }
        public int Ind { get; set; }
        public DateTime? Fecha_intervencion { get; set; }
        public string Area { get; set; }
        public string Equipo_instalacion { get; set; }
        public string Sistemas { get; set; }
        public float? Horas { get; set; }
        public string Descripcion_intervencion { get; set; }
        public string Numero_OT { get; set; }
        public string Codigo_averia { get; set; }
        public string Tipo_mantenimiento { get; set; }
        public bool Cierre_OT { get; set; }
        public string Detalle { get; set; }
        public string Parada { get; set; }
        public string Repuestos { get; set; }
        public string Intervencion_exterior { get; set; }
        public bool Traspasada { get; set; }
    }
}
