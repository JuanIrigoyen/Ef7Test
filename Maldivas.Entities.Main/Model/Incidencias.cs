using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Incidencias
    {
        public int Codigo { get; set; }
        public string Clasificacion { get; set; }
        public string Descripcion { get; set; }
        public string Filtro { get; set; }
        public string Entidad { get; set; }
        public string Sentencia { get; set; }
        public DateTime? Fecha_limite { get; set; }
        public int Dias_plazo { get; set; }
        public string Configuracion { get; set; }
        public string Observaciones { get; set; }
    }
}
