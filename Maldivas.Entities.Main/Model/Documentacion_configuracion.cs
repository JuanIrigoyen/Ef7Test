using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Documentacion_configuracion
    {
        public int Codigo { get; set; }
        public string Documentacion { get; set; }
        public string Grupo { get; set; }
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public string Texto { get; set; }
        public string Observaciones { get; set; }

        public virtual Documentacion_conceptos ConceptoNavigation { get; set; }
        public virtual Documentacion DocumentacionNavigation { get; set; }
    }
}
