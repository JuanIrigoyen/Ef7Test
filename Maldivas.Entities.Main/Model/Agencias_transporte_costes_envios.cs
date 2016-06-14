using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_costes_envios
    {
        public Agencias_transporte_costes_envios()
        {
            Agencias_transporte_etiquetas_temporal = new HashSet<Agencias_transporte_etiquetas_temporal>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public int? Albaran_ventas { get; set; }
        public int? Albaran_compras { get; set; }
        public DateTime? Fecha { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Agente { get; set; }
        public string Agencia { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Cpostal { get; set; }
        public string Direccion { get; set; }
        public bool Portes_debidos { get; set; }
        public bool Reexpedicion { get; set; }
        public int Bultos { get; set; }
        public int Jaulas { get; set; }
        public int Palets { get; set; }
        public decimal Total { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Agencias_transporte_etiquetas_temporal> Agencias_transporte_etiquetas_temporal { get; set; }
        public virtual Agencias_transporte AgenciaNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
    }
}
