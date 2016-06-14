using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Transportistas_evaluacion
    {
        public int Codigo { get; set; }
        public string Transportista { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora_llamada { get; set; }
        public DateTime? Hora_llegada { get; set; }
        public string Valoracion { get; set; }
        public string Colaboracion { get; set; }
        public string Observaciones { get; set; }

        public virtual Valoracion_colaboracion ColaboracionNavigation { get; set; }
        public virtual Agencias_transporte TransportistaNavigation { get; set; }
        public virtual Valoracion_transporte ValoracionNavigation { get; set; }
    }
}
