using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_cursos
    {
        public Formacion_cursos()
        {
            Formacion_cursos_obligatorios = new HashSet<Formacion_cursos_obligatorios>();
            Formacion_cursos_personal = new HashSet<Formacion_cursos_personal>();
            Formacion_registros = new HashSet<Formacion_registros>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public int Clasificacion { get; set; }
        public string Tipo_curso { get; set; }
        public string Tipo_formacion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Formacion_cursos_obligatorios> Formacion_cursos_obligatorios { get; set; }
        public virtual ICollection<Formacion_cursos_personal> Formacion_cursos_personal { get; set; }
        public virtual ICollection<Formacion_registros> Formacion_registros { get; set; }
    }
}
