using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_reclamaciones_detalle
    {
        public int Numero { get; set; }
        public int Codigo { get; set; }
        public int Linea { get; set; }
        public string Ejercicio { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Descripcion { get; set; }
        public string Incidencias { get; set; }
        public string Motivo { get; set; }
        public int Unidades_reclamadas { get; set; }
        public int Unidades_enviadas { get; set; }
        public int Unidades_abonadas { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public DateTime? Factura_fecha { get; set; }
        public int Factura_cantidad { get; set; }
        public int? Factura_numero_linea { get; set; }
        public int? Albaran { get; set; }
        public string Albaran_codigo { get; set; }
        public DateTime? Albaran_fecha { get; set; }
        public int Albaran_cantidad { get; set; }
        public int? Albaran_numero_linea { get; set; }
        public bool Stocks { get; set; }
        public bool Bloqueada { get; set; }
        public int? Lote { get; set; }

        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Compras_reclamaciones_cabecera CodigoNavigation { get; set; }
    }
}
