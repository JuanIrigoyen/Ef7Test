using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Vinculos_externos
    {
        public Vinculos_externos()
        {
            Vinculos_externos_usuarios = new HashSet<Vinculos_externos_usuarios>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Menu { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string Tipo_documento { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Vinculos_externos_usuarios> Vinculos_externos_usuarios { get; set; }
    }
}
