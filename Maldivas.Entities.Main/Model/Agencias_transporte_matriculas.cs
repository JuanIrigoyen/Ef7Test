using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte_matriculas
    {
        public string Agencia { get; set; }
        public string Matricula { get; set; }

        public virtual Agencias_transporte AgenciaNavigation { get; set; }
    }
}
