using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formas_pago_idiomas
    {
        public string Forma_pago { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }

        public virtual Formas_pago Forma_pagoNavigation { get; set; }
        public virtual Lenguajes IdiomaNavigation { get; set; }
    }
}
