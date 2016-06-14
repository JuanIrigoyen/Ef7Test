using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_grupos_tarifas_tipos
    {
        public Clientes_grupos_tarifas_tipos()
        {
            Clientes_grupos_tarifas = new HashSet<Clientes_grupos_tarifas>();
            Clientes_grupos_tarifas_copia = new HashSet<Clientes_grupos_tarifas_copia>();
            Clientes_grupos_tarifas_historico = new HashSet<Clientes_grupos_tarifas_historico>();
            Clientes_grupos_tarifas_temporal = new HashSet<Clientes_grupos_tarifas_temporal>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public string Divisa { get; set; }
        public decimal Comision { get; set; }

        public virtual ICollection<Clientes_grupos_tarifas> Clientes_grupos_tarifas { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_copia> Clientes_grupos_tarifas_copia { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_historico> Clientes_grupos_tarifas_historico { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_temporal> Clientes_grupos_tarifas_temporal { get; set; }
    }
}
