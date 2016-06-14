using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_etiquetas_temporal
    {
        public int Codigo { get; set; }
        public string Envio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Agente { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Cpostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public int Bultos { get; set; }
        public int Kilos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Agencia { get; set; }
        public string Agencia_nombre { get; set; }
        public bool Tipo_transporte { get; set; }
        public string Tipo_servicio { get; set; }
        public bool Reexpedicion { get; set; }
        public string Observaciones { get; set; }

        public virtual Agencias_transporte_costes_envios EnvioNavigation { get; set; }
    }
}
