using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_pedidos_cabecera
    {
        public Ventas_pedidos_cabecera()
        {
            Preparacion_previa_material_unidades = new HashSet<Preparacion_previa_material_unidades>();
            Preparacion_previa_material_volumen = new HashSet<Preparacion_previa_material_volumen>();
            Ventas_pedidos_detalle = new HashSet<Ventas_pedidos_detalle>();
            Ventas_pedidos_embalajes = new HashSet<Ventas_pedidos_embalajes>();
        }

        public int Codigo { get; set; }
        public int? Codaux { get; set; }
        public string Pedido { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Cliente { get; set; }
        public string Agente { get; set; }
        public string Cliente_empresa { get; set; }
        public string Referencia { get; set; }
        public string Serie { get; set; }
        public string Empresa { get; set; }
        public string Usuario { get; set; }
        public int? Proforma { get; set; }
        public string Proforma_codigo { get; set; }
        public DateTime? Proforma_fecha { get; set; }
        public int? Albaran { get; set; }
        public string Albaran_codigo { get; set; }
        public DateTime? Albaran_fecha { get; set; }
        public int? Pedido_origen { get; set; }
        public string Pedido_codigo_origen { get; set; }
        public bool Confirmacion_enviada { get; set; }
        public int? Albaran_origen { get; set; }
        public string Albaran_codigo_origen { get; set; }
        public DateTime? Fecha_entrega { get; set; }
        public DateTime? Fecha_pedido { get; set; }
        public DateTime? Fecha_carga { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Nif { get; set; }
        public short Prioridad { get; set; }
        public bool Aprobado { get; set; }
        public DateTime? Fecha_aprobacion { get; set; }
        public string Forma_pago { get; set; }
        public decimal Descuento_pronto_pago { get; set; }
        public decimal Descuento_volumen { get; set; }
        public decimal Descuento_factura { get; set; }
        public decimal Recargo_total1 { get; set; }
        public decimal Recargo_total2 { get; set; }
        public decimal Recargo_factura { get; set; }
        public decimal Recargo_financiero { get; set; }
        public string Almacen { get; set; }
        public string Tipo_contenedor { get; set; }
        public string Divisa { get; set; }
        public double Divisa_cambio { get; set; }
        public int Divisa_enteros { get; set; }
        public int Divisa_decimales { get; set; }
        public byte Decimales_precios { get; set; }
        public byte Decimales_totales { get; set; }
        public byte Decimales_cantidad { get; set; }
        public string Iva { get; set; }
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
        public string Portes_observaciones { get; set; }
        public decimal Portes_base_imponible { get; set; }
        public decimal Total_portes { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total_costo { get; set; }
        public decimal Total_embalajes_suplementos { get; set; }
        public decimal Total_embalajes { get; set; }
        public decimal Total_peso_neto { get; set; }
        public decimal Total_peso_bruto { get; set; }
        public decimal Total_volumen { get; set; }
        public int Total_unidades { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_recargo_equivalencia { get; set; }
        public decimal Total_descuento_pronto_pago { get; set; }
        public decimal Total_descuento_factura { get; set; }
        public decimal Total_descuento_volumen { get; set; }
        public decimal Total_recargo_factura { get; set; }
        public decimal Total_recargo_financiero { get; set; }
        public decimal Retencion { get; set; }
        public decimal Base_imponible { get; set; }
        public decimal Total_retencion { get; set; }
        public decimal Total_descuento { get; set; }
        public decimal Total_recargo { get; set; }
        public decimal Total_general { get; set; }
        public decimal Total_divisa_base { get; set; }
        public bool Salida { get; set; }
        public bool Pedido_enviado { get; set; }
        public bool Internet_procesado { get; set; }
        public bool Internet_bloqueado { get; set; }
        public bool Impreso { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm2 { get; set; }
        public decimal? Factor_impresion { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_pedido { get; set; }
        public string Observaciones_almacen { get; set; }
        public string Observaciones_obsequios { get; set; }

        public virtual ICollection<Preparacion_previa_material_unidades> Preparacion_previa_material_unidades { get; set; }
        public virtual ICollection<Preparacion_previa_material_volumen> Preparacion_previa_material_volumen { get; set; }
        public virtual ICollection<Ventas_pedidos_detalle> Ventas_pedidos_detalle { get; set; }
        public virtual ICollection<Ventas_pedidos_embalajes> Ventas_pedidos_embalajes { get; set; }
        public virtual Agencias_transporte Agencia_transporteNavigation { get; set; }
        public virtual Agentes AgenteNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Ventas_proformas_cabecera ProformaNavigation { get; set; }
    }
}
