using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_cursos_personal
    {
        public int Codigo { get; set; }
        public string Curso { get; set; }
        public string Departamento { get; set; }
        public string Personal { get; set; }
        public bool? Asistencia { get; set; }
        public string Grado_satisfacion { get; set; }

        public virtual Formacion_cursos CursoNavigation { get; set; }
    }
}
