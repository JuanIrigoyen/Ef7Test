using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_movimientos
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Troquel { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion_movimiento { get; set; }
        public string Tipo { get; set; }
        public string Proveedor { get; set; }

        public virtual Troqueles_tipos_movimientos TipoNavigation { get; set; }
        public virtual Troqueles TroquelNavigation { get; set; }
    }
}
