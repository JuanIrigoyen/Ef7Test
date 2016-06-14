using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_movimientos_historico
    {
        public int Codigo { get; set; }
        public int Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public int Reservado { get; set; }
        public string Descripcion { get; set; }
        public int? Lote { get; set; }
        public int? Documento_codigo { get; set; }
        public string Documento_tipo { get; set; }
        public DateTime? Documento_fecha { get; set; }
        public string Tipo { get; set; }
        public string Operario { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Usuario { get; set; }
    }
}
