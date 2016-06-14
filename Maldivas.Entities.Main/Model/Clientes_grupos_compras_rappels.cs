using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_grupos_compras_rappels
    {
        public int Codigo { get; set; }
        public string Grupo_compra { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_fin { get; set; }
        public decimal Objetivo_inicio { get; set; }
        public decimal Objetivo_fin { get; set; }
        public decimal Rappel { get; set; }
        public string Divisa { get; set; }

        public virtual Clientes_grupos_compras Grupo_compraNavigation { get; set; }
    }
}
