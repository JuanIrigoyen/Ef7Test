using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_albaranes_detalle_ubicaciones
    {
        public int Codigo { get; set; }
        public int? Albaran { get; set; }
        public int? Albaran_numero_linea { get; set; }
        public string Ejercicio { get; set; }
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Ventas_albaranes_detalle Albaran_numero_lineaNavigation { get; set; }
    }
}
