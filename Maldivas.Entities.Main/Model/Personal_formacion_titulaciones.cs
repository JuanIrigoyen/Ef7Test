using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_formacion_titulaciones
    {
        public Personal_formacion_titulaciones()
        {
            Personal_formacion = new HashSet<Personal_formacion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Rama { get; set; }
        public bool? Oficial { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_formacion> Personal_formacion { get; set; }
        public virtual Personal_ramas RamaNavigation { get; set; }
        public virtual Personal_formacion_tipo TipoNavigation { get; set; }
    }
}
