using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_zonas
    {
        public Clientes_zonas()
        {
            Agencias_transporte_zonas = new HashSet<Agencias_transporte_zonas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Nombre { get; set; }
        public string Zona_politica { get; set; }
        public string Zona_iva { get; set; }
        public string Zona_tipo { get; set; }
        public string Zona_cc { get; set; }
        public short Zona_duraccion_cc { get; set; }
        public decimal Objetivo_ejercicio1 { get; set; }
        public decimal Objetivo_ejercicio2 { get; set; }
        public decimal Objetivo_ejercicio3 { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Agencias_transporte_zonas> Agencias_transporte_zonas { get; set; }
    }
}
