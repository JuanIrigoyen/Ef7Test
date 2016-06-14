using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Seguridad_conceptos
    {
        public int Codigo { get; set; }
        public int? Grupo { get; set; }
        public string Coordenada { get; set; }
        public string Valor { get; set; }

        public virtual Seguridad_grupos GrupoNavigation { get; set; }
    }
}
