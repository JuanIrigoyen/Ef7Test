using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_movimientos
    {
        public int Codigo { get; set; }
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

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Articulos_movimientos_documentos_tipos Documento_tipoNavigation { get; set; }
        public virtual Articulos_lotes LoteNavigation { get; set; }
        public virtual Personal OperarioNavigation { get; set; }
        public virtual Articulos_movimientos_tipos TipoNavigation { get; set; }
        public virtual Almacen_ubicaciones Almacen_ubicaciones { get; set; }
    }
}
