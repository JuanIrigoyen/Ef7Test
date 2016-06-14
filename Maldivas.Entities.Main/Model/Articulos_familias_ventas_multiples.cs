using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_familias_ventas_multiples
    {
        public Articulos_familias_ventas_multiples()
        {
            Articulos_familias_ventas_multiples_idiomas = new HashSet<Articulos_familias_ventas_multiples_idiomas>();
        }

        public string Articulo { get; set; }
        public string Subfamilia { get; set; }
        public string Descripcion_tarifa_nacional { get; set; }
        public string Referencia_original { get; set; }

        public virtual ICollection<Articulos_familias_ventas_multiples_idiomas> Articulos_familias_ventas_multiples_idiomas { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
