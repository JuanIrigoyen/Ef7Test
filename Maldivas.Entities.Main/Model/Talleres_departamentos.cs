using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Talleres_departamentos
    {
        public string Taller { get; set; }
        public string Tipo_departamento { get; set; }
        public string Persona_contacto { get; set; }
        public string Observaciones { get; set; }

        public virtual Talleres TallerNavigation { get; set; }
        public virtual Departamentos_tipos Tipo_departamentoNavigation { get; set; }
    }
}
