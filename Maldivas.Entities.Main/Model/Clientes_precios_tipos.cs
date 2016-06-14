using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_precios_tipos
    {
        public Clientes_precios_tipos()
        {
            Articulos_tarifas = new HashSet<Articulos_tarifas>();
            Articulos_tarifas_copia = new HashSet<Articulos_tarifas_copia>();
            Articulos_tarifas_temporal = new HashSet<Articulos_tarifas_temporal>();
            Clientes_grupos_tarifas = new HashSet<Clientes_grupos_tarifas>();
            Clientes_grupos_tarifas_copia = new HashSet<Clientes_grupos_tarifas_copia>();
            Clientes_grupos_tarifas_temporal = new HashSet<Clientes_grupos_tarifas_temporal>();
            Clientes_precios_especiales = new HashSet<Clientes_precios_especiales>();
            Clientes_precios_especiales_cantidad = new HashSet<Clientes_precios_especiales_cantidad>();
            Clientes_precios_especiales_cantidad_copia = new HashSet<Clientes_precios_especiales_cantidad_copia>();
            Clientes_precios_especiales_cantidad_temporal = new HashSet<Clientes_precios_especiales_cantidad_temporal>();
            Clientes_precios_especiales_copia = new HashSet<Clientes_precios_especiales_copia>();
            Clientes_precios_especiales_temporal = new HashSet<Clientes_precios_especiales_temporal>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_tarifas> Articulos_tarifas { get; set; }
        public virtual ICollection<Articulos_tarifas_copia> Articulos_tarifas_copia { get; set; }
        public virtual ICollection<Articulos_tarifas_temporal> Articulos_tarifas_temporal { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas> Clientes_grupos_tarifas { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_copia> Clientes_grupos_tarifas_copia { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_temporal> Clientes_grupos_tarifas_temporal { get; set; }
        public virtual ICollection<Clientes_precios_especiales> Clientes_precios_especiales { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad> Clientes_precios_especiales_cantidad { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_copia> Clientes_precios_especiales_cantidad_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_temporal> Clientes_precios_especiales_cantidad_temporal { get; set; }
        public virtual ICollection<Clientes_precios_especiales_copia> Clientes_precios_especiales_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_temporal> Clientes_precios_especiales_temporal { get; set; }
    }
}
