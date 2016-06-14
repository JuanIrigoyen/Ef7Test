using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_chapa_recubrimiento
    {
        public Articulos_chapa_recubrimiento()
        {
            Articulos_chapa_calidad = new HashSet<Articulos_chapa_calidad>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Espeficicacion { get; set; }
        public string Recubrimiento { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_chapa_calidad> Articulos_chapa_calidad { get; set; }
    }
}
