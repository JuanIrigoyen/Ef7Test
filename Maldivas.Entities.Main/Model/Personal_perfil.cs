using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_perfil
    {
        public int Codigo { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Perfil { get; set; }
        public DateTime? Fecha_edicion { get; set; }
    }
}
