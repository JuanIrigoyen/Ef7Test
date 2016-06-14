using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Transportistas_matriculas
    {
        public string Transportista { get; set; }
        public string Matricula { get; set; }

        public virtual Transportistas TransportistaNavigation { get; set; }
    }
}
