using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_pedidos_detalle
    {
        public Compras_pedidos_detalle()
        {
            Compras_albaranes_entradas = new HashSet<Compras_albaranes_entradas>();
            Etiquetas_registro = new HashSet<Etiquetas_registro>();
        }

        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int? Linea { get; set; }
        public int? Proforma_numero_linea { get; set; }
        public string Ejercicio { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public string Almacen { get; set; }
        public string Descripcion { get; set; }
        public bool Calculo_totales_peso { get; set; }
        public string Centro_coste { get; set; }
        public string Orden_trabajo { get; set; }
        public int? Lanzamiento { get; set; }
        public string Fabricacion_marca { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Formatos { get; set; }
        public decimal Servidas { get; set; }
        public decimal Pendientes { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public string Etiqueta { get; set; }
        public decimal Precio { get; set; }
        public decimal Precio_embalaje { get; set; }
        public decimal Precio_etiqueta { get; set; }
        public decimal Descuento { get; set; }
        public byte Tipo_precio { get; set; }
        public string Iva { get; set; }
        public decimal Iva_porcentaje { get; set; }
        public decimal Re_porcentaje { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_re { get; set; }
        public decimal Total_embalaje { get; set; }
        public decimal Total_linea { get; set; }
        public bool Bloqueada { get; set; }
        public bool Base { get; set; }
        public bool Completada { get; set; }
        public int? Lanzamiento_base { get; set; }

        public virtual ICollection<Compras_albaranes_entradas> Compras_albaranes_entradas { get; set; }
        public virtual ICollection<Etiquetas_registro> Etiquetas_registro { get; set; }
        public virtual Almacen AlmacenNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Centros_coste_financieros Centro_costeNavigation { get; set; }
        public virtual Compras_pedidos_cabecera CodigoNavigation { get; set; }
        public virtual Embalajes EtiquetaNavigation { get; set; }
        public virtual Ivas IvaNavigation { get; set; }
    }
}
