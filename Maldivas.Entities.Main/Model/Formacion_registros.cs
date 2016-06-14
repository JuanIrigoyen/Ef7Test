using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_registros
    {
        public int Codigo { get; set; }
        public string Codigo_operario { get; set; }
        public string Curso { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tipo_curso { get; set; }
        public decimal? Duracion { get; set; }
        public string Impartido { get; set; }
        public string Grado_satisfacion { get; set; }
        public string Registro { get; set; }

        public virtual Formacion_cursos CursoNavigation { get; set; }
    }
}
