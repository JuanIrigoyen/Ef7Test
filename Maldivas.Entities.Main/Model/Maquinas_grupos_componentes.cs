using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Maquinas_grupos_componentes
    {
        public int Codigo { get; set; }
        public int? Grupo { get; set; }
        public string Componente { get; set; }
        public string Sistema { get; set; }
        public string Observaciones { get; set; }
    }
}
