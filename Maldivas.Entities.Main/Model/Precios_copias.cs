using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Precios_copias
    {
        public Precios_copias()
        {
            Articulos_tarifas_copia = new HashSet<Articulos_tarifas_copia>();
            Clientes_grupos_tarifas_copia = new HashSet<Clientes_grupos_tarifas_copia>();
            Clientes_precios_especiales_cantidad_copia = new HashSet<Clientes_precios_especiales_cantidad_copia>();
            Clientes_precios_especiales_copia = new HashSet<Clientes_precios_especiales_copia>();
        }

        public int Operacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool Copia_precios_tarifa { get; set; }
        public bool Copia_grupos_precios { get; set; }
        public bool Copia_precios_especiales { get; set; }
        public bool Copia_precios_especiales_cantidad { get; set; }
        public int Registros_precios_tarifa { get; set; }
        public int Registros_grupos_tarifas { get; set; }
        public int Registros_precios_especiales { get; set; }
        public int Registros_precios_especiales_cantidad { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_tarifas_copia> Articulos_tarifas_copia { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_copia> Clientes_grupos_tarifas_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_copia> Clientes_precios_especiales_cantidad_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_copia> Clientes_precios_especiales_copia { get; set; }
    }
}
