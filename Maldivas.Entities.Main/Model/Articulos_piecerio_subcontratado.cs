using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_piecerio_subcontratado
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public int Fase { get; set; }
        public string Troquel { get; set; }
        public string Operaciones_auxiliares { get; set; }
        public int Unidades_hora { get; set; }
        public string Prensa { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Operaciones_auxiliares Operaciones_auxiliaresNavigation { get; set; }
    }
}
