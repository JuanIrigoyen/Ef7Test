using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Iso_acciones_correctivas
    {
        public int Numero { get; set; }
        public string Accion_descripcion { get; set; }
        public DateTime? Fecha_apertura { get; set; }
        public string Afecta_descripcion { get; set; }
        public string Referencia { get; set; }
        public string Referencia_descripcion { get; set; }
        public string Motivo_descripcion { get; set; }
        public string Motivo_tipo { get; set; }
        public string Propuesta { get; set; }
        public string Accion_propuesta_descripcion { get; set; }
        public string Accion_propuesta { get; set; }
        public string Causa_descripcion { get; set; }
        public string Causa_objetivo { get; set; }
        public string AC_AP_descripcion { get; set; }
        public string AC_AP { get; set; }
        public DateTime? Fecha_inicio_AC { get; set; }
        public decimal? Horas { get; set; }
        public decimal? Material { get; set; }
        public string A_realizadas { get; set; }
        public string Cierre { get; set; }
        public DateTime? Fecha_cierre { get; set; }
        public string Foto { get; set; }
        public string Firma_responsable { get; set; }
        public string Firma_jefe { get; set; }
        public string Firma_VB { get; set; }
    }
}
