using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formulas_calculo_modulos
    {
        public int Codigo { get; set; }
        public int? Formula { get; set; }
        public string Modulo { get; set; }

        public virtual Formulas_calculo FormulaNavigation { get; set; }
    }
}
