using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_formacion
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Personal { get; set; }
        public string Titulacion { get; set; }
        public string Observaciones { get; set; }

        public virtual Personal PersonalNavigation { get; set; }
        public virtual Personal_formacion_titulaciones TitulacionNavigation { get; set; }
    }
}
