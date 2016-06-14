using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_categorias_historico
    {
        public int Codigo { get; set; }
        public string Personal { get; set; }
        public DateTime? Fecha_categoria { get; set; }
        public string Categoria { get; set; }

        public virtual Personal_categorias CategoriaNavigation { get; set; }
        public virtual Personal PersonalNavigation { get; set; }
    }
}
