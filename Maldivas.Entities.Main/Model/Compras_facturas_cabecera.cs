using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_facturas_cabecera
    {
        public Compras_facturas_cabecera()
        {
            Cartera_compras = new HashSet<Cartera_compras>();
            Compras_facturas_detalle = new HashSet<Compras_facturas_detalle>();
            Compras_facturas_detalle_cuentas = new HashSet<Compras_facturas_detalle_cuentas>();
            Remesas_compras_detalle = new HashSet<Remesas_compras_detalle>();
        }

        public int Codigo { get; set; }
        public int? Codaux { get; set; }
        public string Factura { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Mes { get; set; }
        public string Proveedor { get; set; }
        public string Proveedor_empresa { get; set; }
        public string Agente { get; set; }
        public string Referencia { get; set; }
        public DateTime? Fecha_factura { get; set; }
        public string Serie { get; set; }
        public string Usuario { get; set; }
        public string Empresa { get; set; }
        public string Departamento { get; set; }
        public string Nif { get; set; }
        public string Subcuenta_gastos { get; set; }
        public int? Codigo_direccion { get; set; }
        public bool Abono_rappel { get; set; }
        public bool Tratamiento_especial { get; set; }
        public bool Tratamiento_especial_irpf { get; set; }
        public bool Bloqueo_cartera { get; set; }
        public bool Cierre { get; set; }
        public int Asiento { get; set; }
        public bool Aprobado { get; set; }
        public DateTime? Fecha_aprobacion { get; set; }
        public bool Contabilizada { get; set; }
        public byte Pagada { get; set; }
        public bool Analitica_verificada { get; set; }
        public string Forma_pago { get; set; }
        public decimal Descuento_pronto_pago { get; set; }
        public decimal Descuento_volumen { get; set; }
        public decimal Descuento_factura { get; set; }
        public decimal Recargo_factura { get; set; }
        public decimal Retencion { get; set; }
        public decimal Recargo_financiero { get; set; }
        public string Almacen { get; set; }
        public string Divisa { get; set; }
        public int Divisa_decimales { get; set; }
        public int Divisa_enteros { get; set; }
        public double Divisa_cambio { get; set; }
        public byte Decimales_precios { get; set; }
        public byte Decimales_totales { get; set; }
        public byte Decimales_cantidad { get; set; }
        public string Iva { get; set; }
        public string Idioma { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm2 { get; set; }
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
        public decimal Portes_base_imponible { get; set; }
        public decimal Portes_total { get; set; }
        public bool Portes_verificado { get; set; }
        public decimal Portes_coste_aduanas { get; set; }
        public string Portes_factura_aduanas { get; set; }
        public decimal Portes_coste_real { get; set; }
        public decimal Portes_coste_aranceles { get; set; }
        public decimal Portes_coste_transporte { get; set; }
        public decimal Portes_coste_varios { get; set; }
        public DateTime? Portes_fecha_cmr { get; set; }
        public decimal Portes_volumen_cmr { get; set; }
        public string Portes_factura_transporte { get; set; }
        public string Portes_descripcion_varios { get; set; }
        public string Portes_observaciones { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total_portes { get; set; }
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
        public decimal Base_imponible { get; set; }
        public decimal Total_descuento { get; set; }
        public decimal Total_recargo { get; set; }
        public decimal Total_general { get; set; }
        public decimal Total_embalajes_suplementos { get; set; }
        public decimal Total_embalajes { get; set; }
        public decimal Total_divisa_base { get; set; }
        public decimal Total_retencion { get; set; }
        public string Material_origen { get; set; }
        public string Registro_aduanas { get; set; }
        public DateTime? Registro_aduanas_fecha { get; set; }
        public string Dua_numero { get; set; }
        public string Zona_politica { get; set; }
        public string Zona_iva { get; set; }
        public string Zona_tipo { get; set; }
        public bool? Intrastat { get; set; }
        public decimal? Factor_impresion { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_mercancias { get; set; }
        public string Observaciones_forma_pago { get; set; }
        public string Observaciones_administrativas { get; set; }

        public virtual ICollection<Cartera_compras> Cartera_compras { get; set; }
        public virtual ICollection<Compras_facturas_detalle> Compras_facturas_detalle { get; set; }
        public virtual ICollection<Compras_facturas_detalle_cuentas> Compras_facturas_detalle_cuentas { get; set; }
        public virtual ICollection<Remesas_compras_detalle> Remesas_compras_detalle { get; set; }
        public virtual Personal_departamentos DepartamentoNavigation { get; set; }
        public virtual Ivas IvaNavigation { get; set; }
    }
}
