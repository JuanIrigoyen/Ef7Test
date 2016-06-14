using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_reparto_costes
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Area { get; set; }
        public string Seccion { get; set; }
        public string Centro_coste { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual Areas_financieras AreaNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Centros_coste_financieros Centro_costeNavigation { get; set; }
        public virtual Secciones_contables SeccionNavigation { get; set; }
    }
}
