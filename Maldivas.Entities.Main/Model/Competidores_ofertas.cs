using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Competidores_ofertas
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Competidor { get; set; }
        public string Articulo { get; set; }
        public string Sinonimo { get; set; }
        public DateTime? Fecha_oferta { get; set; }
        public string Cliente { get; set; }
        public string Divisa { get; set; }
        public decimal Homogeiniciacion { get; set; }
        public string Incoterm { get; set; }
        public decimal Precio { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Competidores CompetidorNavigation { get; set; }
    }
}
