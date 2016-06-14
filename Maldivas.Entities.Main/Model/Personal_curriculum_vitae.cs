using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_curriculum_vitae
    {
        public int Id { get; set; }
        public string Apellidos_nombre { get; set; }
        public DateTime? Fecha_nacimiento { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public string Idiomas { get; set; }
        public string Provincia { get; set; }
        public string Titulacion { get; set; }
        public string Rama { get; set; }
        public string Departamento { get; set; }
        public string Referencia { get; set; }
        public string Nota { get; set; }
    }
}
