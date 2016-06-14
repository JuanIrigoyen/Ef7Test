using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Iso_reclamaciones
    {
        public string Codigo { get; set; }
        public string Articulo { get; set; }
        public string Contacto { get; set; }
        public DateTime? Fecha_queja { get; set; }
        public string Cliente { get; set; }
        public string Tipo_queja { get; set; }
        public string Causa { get; set; }
        public string Queja { get; set; }
        public string Accion_correctiva { get; set; }
        public string Observaciones { get; set; }
        public bool Solucionado { get; set; }
        public string Responsable { get; set; }
    }
}
