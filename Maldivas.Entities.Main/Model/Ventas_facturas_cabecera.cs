using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_facturas_cabecera
    {
        public Ventas_facturas_cabecera()
        {
            Cartera_ventas = new HashSet<Cartera_ventas>();
            Ventas_facturas_detalle = new HashSet<Ventas_facturas_detalle>();
            Ventas_facturas_embalajes = new HashSet<Ventas_facturas_embalajes>();
            Ventas_reclamaciones_detalle = new HashSet<Ventas_reclamaciones_detalle>();
        }

        public int Codigo { get; set; }
        public int? Codaux { get; set; }
        public string Factura { get; set; }
        public string Mes { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Cliente { get; set; }
        public string Agente { get; set; }
        public string Cliente_empresa { get; set; }
        public string Referencia { get; set; }
        public string Serie { get; set; }
        public string Usuario { get; set; }
        public string Empresa { get; set; }
        public DateTime? Fecha_factura { get; set; }
        public DateTime? Fecha_cobro { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Nif { get; set; }
        public bool Aprobado { get; set; }
        public DateTime? Fecha_aprobacion { get; set; }
        public string Forma_pago { get; set; }
        public int? Asiento { get; set; }
        public string Cesion { get; set; }
        public string Cesion_almacen_origen { get; set; }
        public string Cesion_almacen_destino { get; set; }
        public decimal Comision { get; set; }
        public bool Comision_pagada { get; set; }
        public DateTime? Comision_fecha { get; set; }
        public bool Bloqueo_cartera { get; set; }
        public bool Intrastat { get; set; }
        public bool Contabilizada { get; set; }
        public bool Pagada { get; set; }
        public bool Abono_rappel { get; set; }
        public bool Cierre { get; set; }
        public bool Descripciones { get; set; }
        public bool Documentacion_verificada { get; set; }
        public string Descripciones_valor { get; set; }
        public bool Informe_descripciones { get; set; }
        public string Informe_descripciones_valor { get; set; }
        public decimal Descuento_pronto_pago { get; set; }
        public decimal Descuento_volumen { get; set; }
        public decimal Descuento_factura { get; set; }
        public decimal Recargo_total1 { get; set; }
        public decimal Recargo_total2 { get; set; }
        public decimal Recargo_factura { get; set; }
        public decimal Recargo_financiero { get; set; }
        public string Divisa { get; set; }
        public int Divisa_enteros { get; set; }
        public int Divisa_decimales { get; set; }
        public double Divisa_cambio { get; set; }
        public byte Decimales_precios { get; set; }
        public byte Decimales_totales { get; set; }
        public byte Decimales_cantidad { get; set; }
        public string Iva { get; set; }
        public decimal Retencion { get; set; }
        public string Idioma { get; set; }
        public bool Inhabilitar_peso_por_contenedor { get; set; }
        public string Agencia_transporte { get; set; }
        public string Agente_aduanas { get; set; }
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
        public decimal Total_portes { get; set; }
        public bool Portes_verificado { get; set; }
        public decimal Portes_coste_transporte { get; set; }
        public decimal Portes_coste_aduanas { get; set; }
        public decimal Portes_coste_varios { get; set; }
        public decimal Portes_coste_real { get; set; }
        public string Portes_factura_transporte { get; set; }
        public string Portes_factura_aduanas { get; set; }
        public string Portes_descripcion_varios { get; set; }
        public string Portes_observaciones { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm2 { get; set; }
        public decimal Peso_adicional { get; set; }
        public decimal Peso_embalajes_externos { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Base_imponible { get; set; }
        public int? Anticipo_codigo { get; set; }
        public decimal Anticipo_importe { get; set; }
        public string Anticipo_banco { get; set; }
        public DateTime? Anticipo_fecha { get; set; }
        public decimal Total_costo { get; set; }
        public decimal Portes_base_imponible { get; set; }
        public bool Calculo_manual_peso_neto { get; set; }
        public decimal Total_peso_neto { get; set; }
        public bool Calculo_manual_peso_bruto { get; set; }
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
        public decimal Total_comision { get; set; }
        public decimal Total_descuento { get; set; }
        public decimal Total_recargo { get; set; }
        public decimal Total_general { get; set; }
        public decimal Total_retencion { get; set; }
        public decimal Total_embalajes_suplementos { get; set; }
        public decimal Total_embalajes { get; set; }
        public decimal Total_divisa_base { get; set; }
        public string Material_origen { get; set; }
        public string Partida_arancelaria { get; set; }
        public string Registro_aduanas { get; set; }
        public DateTime? Registro_aduanas_fecha { get; set; }
        public string Dua_numero { get; set; }
        public string Zona_politica { get; set; }
        public string Zona_iva { get; set; }
        public string Zona_tipo { get; set; }
        public decimal? Factor_impresion { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_privadas { get; set; }
        public string Observaciones_forma_pago { get; set; }
        public string Observaciones_mercancias { get; set; }
        public string Observaciones_administrativas { get; set; }
        public bool Calculo_manual_volumen { get; set; }

        public virtual ICollection<Cartera_ventas> Cartera_ventas { get; set; }
        public virtual ICollection<Ventas_facturas_detalle> Ventas_facturas_detalle { get; set; }
        public virtual ICollection<Ventas_facturas_embalajes> Ventas_facturas_embalajes { get; set; }
        public virtual ICollection<Ventas_reclamaciones_detalle> Ventas_reclamaciones_detalle { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Ivas IvaNavigation { get; set; }
    }
}
