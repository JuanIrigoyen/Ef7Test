using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formulas_calculo
    {
        public Formulas_calculo()
        {
            Formulas_calculo_modulos = new HashSet<Formulas_calculo_modulos>();
        }

        public int Codigo { get; set; }
        public int? Orden { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Formulas_calculo_modulos> Formulas_calculo_modulos { get; set; }
    }
}
