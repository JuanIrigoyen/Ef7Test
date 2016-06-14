using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_internet_seguridad_claves
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Grupo { get; set; }
        public int? Clave { get; set; }

        public virtual Clientes_internet_seguridad ClaveNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Clientes_internet_grupos GrupoNavigation { get; set; }
    }
}
