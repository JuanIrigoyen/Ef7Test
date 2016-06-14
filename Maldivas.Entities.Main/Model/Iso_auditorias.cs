using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Iso_auditorias
    {
        public string Numero_auditoria { get; set; }
        public DateTime? Fecha_auditoria { get; set; }
        public string Paginas { get; set; }
        public string Hora_inicio { get; set; }
        public string Hora_final { get; set; }
        public string Departamento { get; set; }
        public string Capitulos { get; set; }
        public string Realizada_por { get; set; }
        public string Firma_realiza { get; set; }
        public string Colabora { get; set; }
        public string Firma_colabora { get; set; }
        public string No_conformidad { get; set; }
        public string AA_CC { get; set; }
        public string Responsable { get; set; }
        public DateTime? Plazo { get; set; }
        public string Comprobaciones { get; set; }
        public DateTime? Fecha_comprobacion { get; set; }
        public string Firma_comprobacion { get; set; }
        public string Anexo { get; set; }
    }
}
