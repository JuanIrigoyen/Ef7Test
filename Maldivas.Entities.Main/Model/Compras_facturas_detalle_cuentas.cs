using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_facturas_detalle_cuentas
    {
        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public int Linea { get; set; }
        public string Ejercicio { get; set; }
        public string Subcuenta { get; set; }
        public string Descripcion { get; set; }
        public string Iva { get; set; }
        public decimal Iva_porcentaje { get; set; }
        public decimal Re_porcentaje { get; set; }
        public decimal Total_iva { get; set; }
        public decimal Total_re { get; set; }
        public decimal Total_linea { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public bool Bloqueada { get; set; }

        public virtual Compras_facturas_cabecera CodigoNavigation { get; set; }
    }
}
