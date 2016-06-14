using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_facturas_detalle
    {
        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int? Linea { get; set; }
        public string Ejercicio { get; set; }
        public int? Albaran_numero_linea { get; set; }
        public string Albaran_codigo { get; set; }
        public DateTime? Albaran_fecha { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Minimo_precio_cantidad { get; set; }
        public byte Tipo_precio { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_re { get; set; }
        public decimal Total_linea { get; set; }
        public bool Bloqueada { get; set; }
        public bool Stocks { get; set; }
        public string Iva { get; set; }
        public decimal Iva_porcentaje { get; set; }
        public decimal Re_porcentaje { get; set; }
        public decimal Precio_embalaje { get; set; }
        public decimal Total_embalaje { get; set; }
        public string Etiqueta { get; set; }
        public decimal Precio_etiqueta { get; set; }

        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Ventas_facturas_cabecera CodigoNavigation { get; set; }
    }
}
