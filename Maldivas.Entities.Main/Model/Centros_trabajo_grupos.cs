using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_trabajo_grupos
    {
        public Centros_trabajo_grupos()
        {
            Centros_trabajo_grupos_relacion = new HashSet<Centros_trabajo_grupos_relacion>();
        }

        public string Grupo { get; set; }
        public string Descripcion { get; set; }
        public string Padre { get; set; }
        public string Sinonimo { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Centros_trabajo_grupos_relacion> Centros_trabajo_grupos_relacion { get; set; }
        public virtual Centros_trabajo_grupos PadreNavigation { get; set; }
        public virtual ICollection<Centros_trabajo_grupos> InversePadreNavigation { get; set; }
    }
}
