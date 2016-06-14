using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_clasificacion
    {
        public Articulos_clasificacion()
        {
            Articulos_clasificacion_relacion = new HashSet<Articulos_clasificacion_relacion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_clasificacion_relacion> Articulos_clasificacion_relacion { get; set; }
    }
}
