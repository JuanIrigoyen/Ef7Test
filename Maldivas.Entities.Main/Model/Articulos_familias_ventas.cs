using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_familias_ventas
    {
        public Articulos_familias_ventas()
        {
            Articulos_familias_ventas_idiomas = new HashSet<Articulos_familias_ventas_idiomas>();
        }

        public int Codigo { get; set; }
        public string Familia { get; set; }
        public string Nivel { get; set; }
        public string Espanol { get; set; }
        public string Mano { get; set; }
        public string Hand { get; set; }
        public short Orden_familia { get; set; }
        public short Orden_subfamilia { get; set; }
        public short Orden_pieza { get; set; }
        public string Grafico { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Articulos_familias_ventas_idiomas> Articulos_familias_ventas_idiomas { get; set; }
    }
}
