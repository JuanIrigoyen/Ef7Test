using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores_certificaciones
    {
        public int Codigo { get; set; }
        public string Tipo_certificacion { get; set; }
        public string Proveedor { get; set; }
        public DateTime? Fecha_caducidad { get; set; }
        public string Organismo_certificador { get; set; }
        public string Documento { get; set; }

        public virtual Proveedores ProveedorNavigation { get; set; }
        public virtual Certificaciones_sistema Tipo_certificacionNavigation { get; set; }
    }
}
