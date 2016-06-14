using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_costes_grupos
    {
        public Centros_costes_grupos()
        {
            Centros_costes_grupos_relacion = new HashSet<Centros_costes_grupos_relacion>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Almacen { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Centros_costes_grupos_relacion> Centros_costes_grupos_relacion { get; set; }
        public virtual Almacen AlmacenNavigation { get; set; }
    }
}
