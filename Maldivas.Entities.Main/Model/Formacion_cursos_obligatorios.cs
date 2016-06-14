using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_cursos_obligatorios
    {
        public int Codigo { get; set; }
        public string Especialidad { get; set; }
        public string Curso { get; set; }

        public virtual Formacion_cursos CursoNavigation { get; set; }
    }
}
