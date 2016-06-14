using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ivas_categorias
    {
        public Ivas_categorias()
        {
            Ivas = new HashSet<Ivas>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }

        public virtual ICollection<Ivas> Ivas { get; set; }
    }
}
