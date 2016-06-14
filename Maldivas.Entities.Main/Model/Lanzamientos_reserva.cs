using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Lanzamientos_reserva
    {
        public int Codigo { get; set; }
        public int? Lanzamiento { get; set; }
        public int? Simulacion { get; set; }
        public int? Orden_trabajo { get; set; }
        public int Control { get; set; }
        public string Padre { get; set; }
        public string Hijo { get; set; }
        public decimal Cantidad { get; set; }
        public int Nivel { get; set; }
        public int Orden { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public bool Procesada { get; set; }

        public virtual Lanzamientos LanzamientoNavigation { get; set; }
    }
}
