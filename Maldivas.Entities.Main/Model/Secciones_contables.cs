using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Secciones_contables
    {
        public Secciones_contables()
        {
            Articulos_reparto_costes = new HashSet<Articulos_reparto_costes>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Area { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Asignacion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_reparto_costes> Articulos_reparto_costes { get; set; }
    }
}
