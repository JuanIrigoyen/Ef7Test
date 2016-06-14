using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_chapa_medida
    {
        public Articulos_chapa_medida()
        {
            Articulos = new HashSet<Articulos>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Espesor_E { get; set; }
        public decimal Ancho_A { get; set; }
        public decimal Largo_B { get; set; }
        public decimal Largo_C { get; set; }
        public decimal Radio_R { get; set; }
        public decimal Paso_P { get; set; }
        public decimal Peso { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos> Articulos { get; set; }
    }
}
