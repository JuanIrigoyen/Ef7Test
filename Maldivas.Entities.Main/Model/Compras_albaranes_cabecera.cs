using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_albaranes_cabecera
    {
        public Compras_albaranes_cabecera()
        {
            Articulos_lotes = new HashSet<Articulos_lotes>();
            Compras_albaranes_detalle = new HashSet<Compras_albaranes_detalle>();
        }

        public int Codigo { get; set; }
        public int? Codaux { get; set; }
        public string Albaran { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Proveedor { get; set; }
        public string Proveedor_empresa { get; set; }
        public string Agente { get; set; }
        public string Empresa { get; set; }
        public string Usuario { get; set; }
        public string Referencia { get; set; }
        public string Subcuenta_gastos { get; set; }
        public string Serie { get; set; }
        public string Departamento { get; set; }
        public DateTime? Fecha_entrega { get; set; }
        public DateTime? Fecha_albaran { get; set; }
        public DateTime? Fecha_factura { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Nif { get; set; }
        public short Prioridad { get; set; }
        public bool Aprobado { get; set; }
        public DateTime? Fecha_aprobacion { get; set; }
        public string Forma_pago { get; set; }
        public decimal Descuento_pronto_pago { get; set; }
        public decimal Descuento_volumen { get; set; }
        public decimal Descuento_factura { get; set; }
        public decimal Recargo_factura { get; set; }
        public decimal Retencion { get; set; }
        public decimal Recargo_financiero { get; set; }
        public string Almacen { get; set; }
        public string Almacen_origen { get; set; }
        public string Almacen_destino { get; set; }
        public string Divisa { get; set; }
        public double Divisa_cambio { get; set; }
        public int Divisa_enteros { get; set; }
        public int Divisa_decimales { get; set; }
        public byte Decimales_precios { get; set; }
        public byte Decimales_totales { get; set; }
        public byte Decimales_cantidad { get; set; }
        public string Iva { get; set; }
        public string Pedido_restos { get; set; }
        public int? Pedido_restos_numero { get; set; }
        public bool Pedido_restos_generar { get; set; }
        public string Idioma { get; set; }
        public string Agencia_transporte { get; set; }
        public byte Portes_tipo { get; set; }
        public string Portes_iva { get; set; }
        public decimal Portes_iva_porcentaje { get; set; }
        public decimal Portes_re_porcentaje { get; set; }
        public decimal Portes_recargo_porcentaje { get; set; }
        public decimal Portes_recargo_total1 { get; set; }
        public decimal Portes_recargo_total2 { get; set; }
        public decimal Portes_recargos { get; set; }
        public decimal Portes_descuento_porcentaje { get; set; }
        public decimal Portes_descuento_total1 { get; set; }
        public decimal Portes_descuento_total2 { get; set; }
        public decimal Portes_descuentos { get; set; }
        public decimal Portes_coste_real { get; set; }
        public string Portes_observaciones { get; set; }
        public decimal Portes_base_imponible { get; set; }
        public decimal Total_portes { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total_embalajes_suplementos { get; set; }
        public decimal Total_embalajes { get; set; }
        public decimal Total_peso_bruto { get; set; }
        public decimal Total_peso_neto { get; set; }
        public decimal Total_volumen { get; set; }
        public int Total_unidades { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_recargo_equivalencia { get; set; }
        public decimal Total_descuento_pronto_pago { get; set; }
        public decimal Total_descuento_factura { get; set; }
        public decimal Total_descuento_volumen { get; set; }
        public decimal Total_recargo_factura { get; set; }
        public decimal Total_recargo_financiero { get; set; }
        public decimal Base_imponible { get; set; }
        public decimal Total_retencion { get; set; }
        public decimal Total_descuento { get; set; }
        public decimal Total_recargo { get; set; }
        public decimal Total_general { get; set; }
        public decimal Total_divisa_base { get; set; }
        public int Calidad_valoracion { get; set; }
        public int Calidad_tipo_servicio { get; set; }
        public int Calidad_documentacion_servicios { get; set; }
        public int Calidad_documentacion { get; set; }
        public int Calidad_embalajes { get; set; }
        public string Calidad_incidencias { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm2 { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public bool Facturado { get; set; }
        public int? Reclamacion { get; set; }
        public string Reclamacion_codigo { get; set; }
        public decimal? Factor_impresion { get; set; }
        public string Observaciones_generales { get; set; }

        public virtual ICollection<Articulos_lotes> Articulos_lotes { get; set; }
        public virtual ICollection<Compras_albaranes_detalle> Compras_albaranes_detalle { get; set; }
        public virtual Personal_departamentos DepartamentoNavigation { get; set; }
        public virtual Formas_pago Forma_pagoNavigation { get; set; }
        public virtual Ivas IvaNavigation { get; set; }
        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
