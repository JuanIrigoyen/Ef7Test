using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Operaciones_auxiliares
    {
        public Operaciones_auxiliares()
        {
            Articulos_piecerio_subcontratado = new HashSet<Articulos_piecerio_subcontratado>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_piecerio_subcontratado> Articulos_piecerio_subcontratado { get; set; }
    }
}
