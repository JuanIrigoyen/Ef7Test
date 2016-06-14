using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_grupos_trabajo
    {
        public Personal_grupos_trabajo()
        {
            Personal_grupos_trabajo_relacion = new HashSet<Personal_grupos_trabajo_relacion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_tareas { get; set; }
        public string Seccion { get; set; }
        public string Responsable { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_grupos_trabajo_relacion> Personal_grupos_trabajo_relacion { get; set; }
    }
}
