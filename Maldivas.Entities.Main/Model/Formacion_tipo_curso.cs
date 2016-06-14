using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_tipo_curso
    {
        public Formacion_tipo_curso()
        {
            Formacion_cursos_descripcion = new HashSet<Formacion_cursos_descripcion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Formacion_cursos_descripcion> Formacion_cursos_descripcion { get; set; }
    }
}
