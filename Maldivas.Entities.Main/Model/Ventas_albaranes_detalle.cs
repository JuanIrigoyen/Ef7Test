using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_albaranes_detalle
    {
        public Ventas_albaranes_detalle()
        {
            Ventas_albaranes_carga = new HashSet<Ventas_albaranes_carga>();
            Ventas_albaranes_detalle_ubicaciones = new HashSet<Ventas_albaranes_detalle_ubicaciones>();
        }

        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int? Linea { get; set; }
        public string Ejercicio { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public int Minimo_precio_cantidad { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public decimal Precio { get; set; }
        public byte Tipo_precio { get; set; }
        public decimal Descuento { get; set; }
        public int Pedidas { get; set; }
        public decimal Pendientes { get; set; }
        public int? Pedido { get; set; }
        public string Pedido_codigo { get; set; }
        public DateTime? Pedido_fecha { get; set; }
        public int? Pedido_numero_linea { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public DateTime? Factura_fecha { get; set; }
        public int? Factura_numero_linea { get; set; }
        public decimal Precio_costo { get; set; }
        public string Iva { get; set; }
        public decimal Iva_porcentaje { get; set; }
        public decimal Re_porcentaje { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_re { get; set; }
        public decimal Total_linea { get; set; }
        public string Reclamacion_codigo { get; set; }
        public int? Reclamacion_numero_linea { get; set; }
        public bool Stocks { get; set; }
        public bool Bloqueada { get; set; }
        public decimal Precio_embalaje { get; set; }
        public decimal Total_embalaje { get; set; }
        public string Etiqueta { get; set; }
        public decimal Precio_etiqueta { get; set; }
        public string Centro_coste { get; set; }
        public string Orden_trabajo { get; set; }

        public virtual ICollection<Ventas_albaranes_carga> Ventas_albaranes_carga { get; set; }
        public virtual ICollection<Ventas_albaranes_detalle_ubicaciones> Ventas_albaranes_detalle_ubicaciones { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Ventas_albaranes_cabecera CodigoNavigation { get; set; }
    }
}
