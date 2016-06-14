using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_formacion_idiomas
    {
        public int Codigo { get; set; }
        public string Personal { get; set; }
        public string Idioma { get; set; }
        public byte Nivel_hablado { get; set; }
        public byte Nivel_escrito { get; set; }
        public string Observaciones { get; set; }

        public virtual Personal_idiomas IdiomaNavigation { get; set; }
        public virtual Personal PersonalNavigation { get; set; }
    }
}
