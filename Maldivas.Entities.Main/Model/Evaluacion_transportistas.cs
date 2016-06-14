using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Evaluacion_transportistas
    {
        public string Transportista { get; set; }
        public int Total_horas { get; set; }
        public int Indice_plazos_entrega { get; set; }
        public int Valoracion_camiones { get; set; }
        public int Indice_transporte { get; set; }
        public int Numero_transportes { get; set; }
        public int Indice_colaboracion { get; set; }
        public int Valoracion_transportista { get; set; }
        public string Tipo { get; set; }
    }
}
