using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_idiomas
    {
        public Personal_idiomas()
        {
            Personal_formacion_idiomas = new HashSet<Personal_formacion_idiomas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_formacion_idiomas> Personal_formacion_idiomas { get; set; }
    }
}
