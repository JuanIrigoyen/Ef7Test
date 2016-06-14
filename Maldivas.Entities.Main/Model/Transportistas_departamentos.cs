using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Transportistas_departamentos
    {
        public string Transportista { get; set; }
        public string Tipo_departamento { get; set; }
        public string Persona_contacto { get; set; }
        public string Observaciones { get; set; }

        public virtual Transportistas TransportistaNavigation { get; set; }
    }
}
