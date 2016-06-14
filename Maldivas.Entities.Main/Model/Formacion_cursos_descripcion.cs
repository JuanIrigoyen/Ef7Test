using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_cursos_descripcion
    {
        public string Codigo { get; set; }
        public string Ejercicio { get; set; }
        public string Curso { get; set; }
        public string Situacion_curso { get; set; }
        public string Tipo_curso { get; set; }
        public string Tipo_formacion { get; set; }
        public string Lugar { get; set; }
        public string Empresa { get; set; }
        public string Monitor { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public decimal Coste_curso { get; set; }
        public decimal Coste_personal { get; set; }
        public int Horas_duracion { get; set; }
        public bool Realizado { get; set; }
        public string Observaciones { get; set; }

        public virtual Formacion_tipo_curso Tipo_cursoNavigation { get; set; }
        public virtual Formacion_tipo_formacion Tipo_formacionNavigation { get; set; }
    }
}
