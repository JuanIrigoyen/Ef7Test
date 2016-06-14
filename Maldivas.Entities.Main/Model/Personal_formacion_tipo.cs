using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_formacion_tipo
    {
        public Personal_formacion_tipo()
        {
            Personal_formacion_titulaciones = new HashSet<Personal_formacion_titulaciones>();
        }

        public string Codigo { get; set; }
        public int? Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_formacion_titulaciones> Personal_formacion_titulaciones { get; set; }
    }
}
