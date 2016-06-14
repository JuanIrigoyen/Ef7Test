using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Competidores_articulos_certificados
    {
        public string Competidor { get; set; }
        public string Articulo { get; set; }
        public string Certificacion { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Competidores CompetidorNavigation { get; set; }
    }
}
