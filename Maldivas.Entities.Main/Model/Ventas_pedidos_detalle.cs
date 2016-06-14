using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_pedidos_detalle
    {
        public Ventas_pedidos_detalle()
        {
            Preparacion_previa_material_unidades = new HashSet<Preparacion_previa_material_unidades>();
            Preparacion_previa_material_volumen = new HashSet<Preparacion_previa_material_volumen>();
        }

        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int? Linea { get; set; }
        public string Ejercicio { get; set; }
        public int? Proforma { get; set; }
        public string Proforma_codigo { get; set; }
        public DateTime? Proforma_fecha { get; set; }
        public int? Proforma_numero_linea { get; set; }
        public int? Albaran { get; set; }
        public string Albaran_codigo { get; set; }
        public DateTime? Albaran_fecha { get; set; }
        public int? Albaran_numero_linea { get; set; }
        public int? Codaux { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Servidas { get; set; }
        public decimal Pendientes { get; set; }
        public int Minimo_precio_cantidad { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Precio { get; set; }
        public byte Tipo_precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Precio_costo { get; set; }
        public string Iva { get; set; }
        public decimal Iva_porcentaje { get; set; }
        public decimal Re_porcentaje { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_re { get; set; }
        public decimal Total_linea { get; set; }
        public bool Bloqueada { get; set; }
        public bool Base { get; set; }
        public bool Completada { get; set; }
        public string Orden_trabajo { get; set; }
        public string Centro_coste { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public decimal Precio_embalaje { get; set; }
        public decimal Total_embalaje { get; set; }
        public string Etiqueta { get; set; }
        public decimal Precio_etiqueta { get; set; }

        public virtual ICollection<Preparacion_previa_material_unidades> Preparacion_previa_material_unidades { get; set; }
        public virtual ICollection<Preparacion_previa_material_volumen> Preparacion_previa_material_volumen { get; set; }
        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Ventas_pedidos_cabecera CodigoNavigation { get; set; }
        public virtual Embalajes EtiquetaNavigation { get; set; }
        public virtual Ivas IvaNavigation { get; set; }
    }
}
