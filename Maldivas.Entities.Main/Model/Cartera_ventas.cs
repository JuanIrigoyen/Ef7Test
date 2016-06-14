using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Cartera_ventas
    {
        public Cartera_ventas()
        {
            Cartera_ventas_historico = new HashSet<Cartera_ventas_historico>();
            Remesas_ventas_detalle = new HashSet<Remesas_ventas_detalle>();
        }

        public int Codigo { get; set; }
        public int? Factura { get; set; }
        public DateTime? Factura_fecha { get; set; }
        public string Factura_codigo { get; set; }
        public string Factura_ejercicio { get; set; }
        public string Factura_modo { get; set; }
        public int Bolsa { get; set; }
        public string Subcuenta_ventas { get; set; }
        public string Referencia { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Cliente { get; set; }
        public string Agente { get; set; }
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
        public decimal Gastos_reclamacion { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }
        public decimal Total_divisa_base { get; set; }
        public decimal Diferencia_cambio { get; set; }
        public string Importe_caracter { get; set; }
        public string Divisa { get; set; }
        public string Divisa_base { get; set; }
        public decimal Divisa_cambio_factura { get; set; }
        public decimal Divisa_cambio_cobro { get; set; }
        public int? Banco_cobro_codigo { get; set; }
        public string Banco_cobro_nombre { get; set; }
        public string Banco_cobro_entidad { get; set; }
        public string Banco_cobro_agencia { get; set; }
        public string Banco_cobro_dc { get; set; }
        public string Banco_cobro_cuenta { get; set; }
        public string Banco_cobro_subcuenta { get; set; }
        public int? Banco_receptor_codigo { get; set; }
        public string Banco_receptor_nombre { get; set; }
        public string Banco_receptor_entidad { get; set; }
        public string Banco_receptor_agencia { get; set; }
        public string Banco_receptor_dc { get; set; }
        public string Banco_receptor_cuenta { get; set; }
        public string Banco_receptor_subcuenta { get; set; }
        public DateTime? Fecha_recepcion { get; set; }
        public DateTime? Fecha_vencimiento { get; set; }
        public DateTime? Fecha_orden_pago { get; set; }
        public DateTime? Fecha_cobro { get; set; }
        public DateTime? Fecha_devolucion { get; set; }
        public DateTime? Fecha_cancelacion { get; set; }
        public bool Generar_asiento { get; set; }
        public bool Notificado { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Cartera_ventas_historico> Cartera_ventas_historico { get; set; }
        public virtual ICollection<Remesas_ventas_detalle> Remesas_ventas_detalle { get; set; }
        public virtual Ventas_facturas_cabecera FacturaNavigation { get; set; }
    }
}
