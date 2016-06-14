using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_departamentos
    {
        public string Cliente { get; set; }
        public string Tipo_departamento { get; set; }
        public string Persona_contacto { get; set; }
        public string Observaciones { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Departamentos_tipos Tipo_departamentoNavigation { get; set; }
    }
}
