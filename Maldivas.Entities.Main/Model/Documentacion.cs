using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Documentacion
    {
        public Documentacion()
        {
            Clientes = new HashSet<Clientes>();
            Documentacion_configuracion = new HashSet<Documentacion_configuracion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Documentacion_configuracion> Documentacion_configuracion { get; set; }
    }
}
