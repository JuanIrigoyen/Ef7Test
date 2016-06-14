using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_albaranes_carga_salidas
    {
        public int Codigo { get; set; }
        public int Albaran { get; set; }
        public string Matricula { get; set; }
        public string Contenedor { get; set; }
        public string Transporte_tipo { get; set; }
        public string Precinto { get; set; }
        public DateTime? Hora_inicio { get; set; }
        public DateTime? Hora_final { get; set; }
        public DateTime? Hora_salida { get; set; }
        public short Jaulas { get; set; }
        public short Palets { get; set; }
        public short Cajas { get; set; }
        public short Canchadas { get; set; }
        public decimal Coste { get; set; }
        public decimal Unidades { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Peso_embalajes { get; set; }
        public decimal Peso_bruto_adicional { get; set; }
        public decimal Volumen_bruto { get; set; }
        public decimal Porcentaje { get; set; }
        public int? Salida { get; set; }

        public virtual Ventas_albaranes_cabecera AlbaranNavigation { get; set; }
    }
}
