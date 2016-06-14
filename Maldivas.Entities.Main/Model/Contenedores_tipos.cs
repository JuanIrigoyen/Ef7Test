using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Contenedores_tipos
    {
        public Contenedores_tipos()
        {
            Articulos_contenedores_capacidad = new HashSet<Articulos_contenedores_capacidad>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Volumen { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_contenedores_capacidad> Articulos_contenedores_capacidad { get; set; }
    }
}
