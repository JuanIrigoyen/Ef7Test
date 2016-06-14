using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_albaranes_detalle
    {
        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int? Linea { get; set; }
        public string Ejercicio { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int? Lote { get; set; }
        public string Descripcion { get; set; }
        public bool Calculo_totales_peso { get; set; }
        public string Centro_coste { get; set; }
        public string Orden_trabajo { get; set; }
        public decimal Pedidas { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Pendientes { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public string Etiqueta { get; set; }
        public decimal Precio { get; set; }
        public decimal Precio_embalaje { get; set; }
        public decimal Precio_etiqueta { get; set; }
        public byte Tipo_precio { get; set; }
        public decimal Descuento { get; set; }
        public string Iva { get; set; }
        public decimal Iva_porcentaje { get; set; }
        public decimal Re_porcentaje { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_re { get; set; }
        public decimal Total_embalaje { get; set; }
        public decimal Total_linea { get; set; }
        public bool Bloqueada { get; set; }
        public bool Stocks { get; set; }
        public string Reclamacion_codigo { get; set; }
        public int? Reclamacion_numero_linea { get; set; }
        public string Pedido_codigo { get; set; }
        public int? Pedido { get; set; }
        public DateTime? Pedido_fecha { get; set; }
        public int? Pedido_numero_linea { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public DateTime? Factura_fecha { get; set; }
        public int? Factura_numero_linea { get; set; }
        public string Calidad_especifica { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Articulos_chapa_calidad Calidad_especificaNavigation { get; set; }
        public virtual Compras_albaranes_cabecera CodigoNavigation { get; set; }
        public virtual Ivas IvaNavigation { get; set; }
    }
}
