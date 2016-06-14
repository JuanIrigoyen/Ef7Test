using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Cartera_compras_historico
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Recibo { get; set; }
        public int? Bolsa { get; set; }
        public string Estado { get; set; }
        public decimal Importe { get; set; }
        public decimal Comision_bancaria { get; set; }
        public decimal Gastos_devolucion { get; set; }
        public decimal Gastos_reclamacion { get; set; }
        public decimal Divisa_cambio_factura { get; set; }
        public decimal Divisa_cambio_pago { get; set; }
        public decimal Total { get; set; }

        public virtual Cartera_compras ReciboNavigation { get; set; }
    }
}
