using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_competidores_acuerdos
    {
        public string Articulo { get; set; }
        public string Competidor { get; set; }
        public DateTime Fecha_inicial { get; set; }
        public DateTime? Fecha_final { get; set; }
        public string Estado { get; set; }
        public string Divisa { get; set; }
        public decimal Precio_minimo { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
