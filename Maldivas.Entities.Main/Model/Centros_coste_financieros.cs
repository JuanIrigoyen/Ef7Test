using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_coste_financieros
    {
        public Centros_coste_financieros()
        {
            Articulos_reparto_costes = new HashSet<Articulos_reparto_costes>();
            Compras_pedidos_detalle = new HashSet<Compras_pedidos_detalle>();
            Compras_proformas_detalle = new HashSet<Compras_proformas_detalle>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_reparto_costes> Articulos_reparto_costes { get; set; }
        public virtual ICollection<Compras_pedidos_detalle> Compras_pedidos_detalle { get; set; }
        public virtual ICollection<Compras_proformas_detalle> Compras_proformas_detalle { get; set; }
    }
}
