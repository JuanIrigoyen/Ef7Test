using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_facturas_embalajes
    {
        public int Factura { get; set; }
        public string Embalaje { get; set; }
        public int Cantidad { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public bool Calculo { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        public virtual Embalajes EmbalajeNavigation { get; set; }
        public virtual Ventas_facturas_cabecera FacturaNavigation { get; set; }
    }
}
