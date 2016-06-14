using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_trabajo
    {
        public Centros_trabajo()
        {
            Articulos_fases = new HashSet<Articulos_fases>();
            Centros_trabajo_grupos_relacion = new HashSet<Centros_trabajo_grupos_relacion>();
            Maquinas_centros_trabajo_relacion = new HashSet<Maquinas_centros_trabajo_relacion>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public long Capacidad_diaria { get; set; }
        public string Tipo { get; set; }
        public string Observacion { get; set; }

        public virtual ICollection<Articulos_fases> Articulos_fases { get; set; }
        public virtual ICollection<Centros_trabajo_grupos_relacion> Centros_trabajo_grupos_relacion { get; set; }
        public virtual ICollection<Maquinas_centros_trabajo_relacion> Maquinas_centros_trabajo_relacion { get; set; }
        public virtual Almacen AlmacenNavigation { get; set; }
    }
}
