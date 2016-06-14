using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_categorias
    {
        public Personal_categorias()
        {
            Personal_categorias_historico = new HashSet<Personal_categorias_historico>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal_categorias_historico> Personal_categorias_historico { get; set; }
    }
}
