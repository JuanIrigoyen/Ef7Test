using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Incoterms
    {
        public Incoterms()
        {
            Compras_pedidos_cabecera = new HashSet<Compras_pedidos_cabecera>();
            Compras_proformas_cabeceraIncoterm1Navigation = new HashSet<Compras_proformas_cabecera>();
            Compras_proformas_cabeceraIncoterm2Navigation = new HashSet<Compras_proformas_cabecera>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string Puerto_embarque { get; set; }
        public byte Tipo { get; set; }
        public byte Transporte { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual ICollection<Compras_proformas_cabecera> Compras_proformas_cabeceraIncoterm1Navigation { get; set; }
        public virtual ICollection<Compras_proformas_cabecera> Compras_proformas_cabeceraIncoterm2Navigation { get; set; }
        public virtual Puertos_embarque Puerto_embarqueNavigation { get; set; }
    }
}
