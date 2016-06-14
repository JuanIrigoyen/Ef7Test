using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_rappels
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public bool Validar_fecha { get; set; }
        public int Objetivo_inicial { get; set; }
        public int Objetivo_final { get; set; }
        public decimal Descuento { get; set; }
        public string Observaciones { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
    }
}
