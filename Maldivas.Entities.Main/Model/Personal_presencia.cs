using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_presencia
    {
        public Personal_presencia()
        {
            Personal_presencia_fotos = new HashSet<Personal_presencia_fotos>();
        }

        public int Codigo { get; set; }
        public string Personal { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_presencia_fotos> Personal_presencia_fotos { get; set; }
        public virtual Personal PersonalNavigation { get; set; }
        public virtual Personal_presencia_tipos TipoNavigation { get; set; }
    }
}
