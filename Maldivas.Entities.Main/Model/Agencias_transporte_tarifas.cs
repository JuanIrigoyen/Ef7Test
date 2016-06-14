using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_tarifas
    {
        public int Codigo { get; set; }
        public string Agencia { get; set; }
        public string Zona_agencia { get; set; }
        public decimal Kg_inicial { get; set; }
        public decimal Kg_final { get; set; }
        public decimal Fijo { get; set; }
        public decimal Minimo { get; set; }
        public decimal Precio { get; set; }
        public decimal Precio_kg { get; set; }
        public string Observaciones { get; set; }

        public virtual Agencias_transporte AgenciaNavigation { get; set; }
    }
}
