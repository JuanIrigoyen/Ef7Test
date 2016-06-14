using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Lenguajes
    {
        public Lenguajes()
        {
            Articulos_etiquetas_idiomas = new HashSet<Articulos_etiquetas_idiomas>();
            Articulos_familias_ventas_idiomas = new HashSet<Articulos_familias_ventas_idiomas>();
            Articulos_idiomas = new HashSet<Articulos_idiomas>();
            Embalajes_idiomas = new HashSet<Embalajes_idiomas>();
            Formas_pago_idiomas = new HashSet<Formas_pago_idiomas>();
        }

        public string Codigo { get; set; }

        public virtual ICollection<Articulos_etiquetas_idiomas> Articulos_etiquetas_idiomas { get; set; }
        public virtual ICollection<Articulos_familias_ventas_idiomas> Articulos_familias_ventas_idiomas { get; set; }
        public virtual ICollection<Articulos_idiomas> Articulos_idiomas { get; set; }
        public virtual ICollection<Embalajes_idiomas> Embalajes_idiomas { get; set; }
        public virtual ICollection<Formas_pago_idiomas> Formas_pago_idiomas { get; set; }
    }
}
