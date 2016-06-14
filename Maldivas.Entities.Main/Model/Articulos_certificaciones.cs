using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_certificaciones
    {
        public string Articulo { get; set; }
        public string Certificacion { get; set; }
        public string Referencia { get; set; }
        public string Propietario { get; set; }
        public DateTime? Fecha_inicial { get; set; }
        public DateTime? Fecha_caducidad { get; set; }
        public string Documento { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
