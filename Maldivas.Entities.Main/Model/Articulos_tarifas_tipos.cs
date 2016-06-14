using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_tarifas_tipos
    {
        public Articulos_tarifas_tipos()
        {
            Articulos_tarifas = new HashSet<Articulos_tarifas>();
            Articulos_tarifas_temporal = new HashSet<Articulos_tarifas_temporal>();
            Clientes = new HashSet<Clientes>();
        }

        public int Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public int Decimales { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_tarifas> Articulos_tarifas { get; set; }
        public virtual ICollection<Articulos_tarifas_temporal> Articulos_tarifas_temporal { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
