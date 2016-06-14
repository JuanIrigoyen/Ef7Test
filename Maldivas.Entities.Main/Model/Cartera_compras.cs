using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Cartera_compras
    {
        public Cartera_compras()
        {
            Cartera_compras_historico = new HashSet<Cartera_compras_historico>();
        }

        public int Codigo { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public string Factura_ejercicio { get; set; }
        public string Factura_modo { get; set; }
        public DateTime? Factura_fecha { get; set; }
        public int Bolsa { get; set; }
        public string Proveedor { get; set; }
        public string Referencia { get; set; }
        public string Subcuenta_gastos { get; set; }
        public string Subcuenta_compras { get; set; }
        public string Agente { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Serie { get; set; }
        public short Recibo { get; set; }
        public int? Asiento { get; set; }
        public int? Remesa { get; set; }
        public string Remesa_codigo { get; set; }
        public string Remesa_ejercicio { get; set; }
        public string Remesa_modo { get; set; }
        public int? Remesa_numero { get; set; }
        public DateTime? Remesa_fecha { get; set; }
        public int? Abono_recibo_codigo { get; set; }
        public decimal Abono_recibo_importe { get; set; }
        public string Concepto { get; set; }
        public string Estado { get; set; }
        public byte Tipo { get; set; }
        public decimal Comision_bancaria { get; set; }
        public decimal Gastos_devolucion { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }
        public decimal Total_divisa_base { get; set; }
        public decimal Diferencia_cambio { get; set; }
        public string Importe_caracter { get; set; }
        public string Divisa { get; set; }
        public string Divisa_base { get; set; }
        public decimal Divisa_cambio_factura { get; set; }
        public decimal Divisa_cambio_pago { get; set; }
        public int? Banco_pago_codigo { get; set; }
        public string Banco_pago_nombre { get; set; }
        public string Banco_pago_entidad { get; set; }
        public string Banco_pago_agencia { get; set; }
        public string Banco_pago_dc { get; set; }
        public string Banco_pago_cuenta { get; set; }
        public string Banco_pago_subcuenta { get; set; }
        public int? Banco_receptor_codigo { get; set; }
        public string Banco_receptor_nombre { get; set; }
        public string Banco_receptor_entidad { get; set; }
        public string Banco_receptor_agencia { get; set; }
        public string Banco_receptor_dc { get; set; }
        public string Banco_receptor_cuenta { get; set; }
        public string Banco_receptor_subcuenta { get; set; }
        public DateTime? Fecha_vencimiento { get; set; }
        public DateTime? Fecha_cobro { get; set; }
        public DateTime? Fecha_devolucion { get; set; }
        public DateTime? Fecha_orden_pago { get; set; }
        public DateTime? Fecha_cancelacion { get; set; }
        public bool Generar_asiento { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Cartera_compras_historico> Cartera_compras_historico { get; set; }
        public virtual Compras_facturas_cabecera FacturaNavigation { get; set; }
        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
