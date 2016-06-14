using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Evaluacion_proveedor_servicios
    {
        public string Proveedor { get; set; }
        public int Total_horas { get; set; }
        public int Indice_horas { get; set; }
        public int Satisfecho { get; set; }
        public int Problemas_menores { get; set; }
        public int Problemas_importantes { get; set; }
        public int Servicio_deficiente { get; set; }
        public int Indice_satisfaccion { get; set; }
        public int Servicios_urgentes { get; set; }
        public int Indice_tiempo_respuesta { get; set; }
        public int Documentacion_completa { get; set; }
        public int Documentacion_suficiente { get; set; }
        public int Documentacion_insuficiente { get; set; }
        public int Indice_documentacion { get; set; }
        public int Valoracion_proveedor { get; set; }
        public string Tipo { get; set; }
    }
}
