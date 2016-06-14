using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Embalajes_idiomas
    {
        public string Embalaje { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }

        public virtual Embalajes EmbalajeNavigation { get; set; }
        public virtual Lenguajes IdiomaNavigation { get; set; }
    }
}
