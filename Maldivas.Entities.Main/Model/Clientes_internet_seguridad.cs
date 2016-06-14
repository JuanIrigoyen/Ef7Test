using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_internet_seguridad
    {
        public Clientes_internet_seguridad()
        {
            Clientes_internet_seguridad_claves = new HashSet<Clientes_internet_seguridad_claves>();
        }

        public int Clave { get; set; }
        public int Padre { get; set; }
        public short Imagen { get; set; }
        public string Variable { get; set; }
        public string Contenido { get; set; }
        public bool Acceso { get; set; }

        public virtual ICollection<Clientes_internet_seguridad_claves> Clientes_internet_seguridad_claves { get; set; }
    }
}
