using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_reclamaciones_detalle
    {
        public int Numero { get; set; }
        public int Codigo { get; set; }
        public string Ejercicio { get; set; }
        public int Linea { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Descripcion { get; set; }
        public string Incidencias { get; set; }
        public string Motivo { get; set; }
        public int Unidades_reclamadas { get; set; }
        public int Unidades_recibidas { get; set; }
        public int Unidades_perfectas { get; set; }
        public int Unidades_pintadas { get; set; }
        public int Unidades_abolladas { get; set; }
        public int Unidades_chatarra { get; set; }
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
        public bool Forzar_abono { get; set; }

        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Ventas_reclamaciones_cabecera CodigoNavigation { get; set; }
        public virtual Ventas_facturas_cabecera FacturaNavigation { get; set; }
    }
}
