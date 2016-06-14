using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_conjuntos
    {
        public string Padre { get; set; }
        public string Hijo { get; set; }
        public int Orden { get; set; }
        public double Unidades_netas { get; set; }
        public double Desperdicio { get; set; }
        public double Perdida_preparacion { get; set; }
        public DateTime? Fecha_inicio_ingenieria { get; set; }
        public DateTime? Fecha_final_ingenieria { get; set; }
        public bool Fabricacion_lotes { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public DateTime? Fecha_ultima_modificacion { get; set; }
        public bool Verificar_stock { get; set; }
        public bool Generar_pedido { get; set; }

        public virtual Articulos HijoNavigation { get; set; }
        public virtual Articulos PadreNavigation { get; set; }
    }
}
