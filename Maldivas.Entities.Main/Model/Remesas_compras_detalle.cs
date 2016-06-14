using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Remesas_compras_detalle
    {
        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int? Linea { get; set; }
        public int? Cartera_recibo { get; set; }
        public string Proveedor { get; set; }
        public int? Factura { get; set; }
        public string Factura_codigo { get; set; }
        public string Factura_ejercicio { get; set; }
        public string Factura_modo { get; set; }
        public string Referencia { get; set; }
        public int? Codigo_direccion { get; set; }
        public DateTime? Fecha_factura { get; set; }
        public DateTime? Fecha_vencimiento { get; set; }
        public byte? Recibo { get; set; }
        public string Concepto { get; set; }
        public decimal? Total { get; set; }
        public short Repeticiones { get; set; }
        public bool Notificacion { get; set; }
        public bool Bloqueada { get; set; }

        public virtual Remesas_compras_cabecera CodigoNavigation { get; set; }
        public virtual Compras_facturas_cabecera FacturaNavigation { get; set; }
    }
}
