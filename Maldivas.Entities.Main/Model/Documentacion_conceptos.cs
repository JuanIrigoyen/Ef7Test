using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Documentacion_conceptos
    {
        public Documentacion_conceptos()
        {
            Documentacion_configuracion = new HashSet<Documentacion_configuracion>();
        }

        public string Codigo { get; set; }
        public string Grupo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Documentacion_configuracion> Documentacion_configuracion { get; set; }
        public virtual Documentacion_grupos GrupoNavigation { get; set; }
    }
}
