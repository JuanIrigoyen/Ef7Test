using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_presencia_tipos
    {
        public Personal_presencia_tipos()
        {
            Personal_presencia = new HashSet<Personal_presencia>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_presencia> Personal_presencia { get; set; }
    }
}
