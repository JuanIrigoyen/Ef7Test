using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Competidores_sinonimos
    {
        public string Competidor { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }

        public virtual Competidores CompetidorNavigation { get; set; }
    }
}
