using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_perfil_tareas
    {
        public int PerfilTareaId { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Tareas { get; set; }
        public DateTime? Fecha_Edicion { get; set; }
    }
}
