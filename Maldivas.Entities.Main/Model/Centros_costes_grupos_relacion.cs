using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_costes_grupos_relacion
    {
        public int Codigo { get; set; }
        public string Grupo { get; set; }
        public string Centro { get; set; }
        public bool Interna { get; set; }

        public virtual Centros_costes CentroNavigation { get; set; }
        public virtual Centros_costes_grupos GrupoNavigation { get; set; }
    }
}
