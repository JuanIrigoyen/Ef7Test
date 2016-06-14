using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Lanzamientos
    {
        public Lanzamientos()
        {
            Lanzamientos_reserva = new HashSet<Lanzamientos_reserva>();
            Ordenes_trabajo = new HashSet<Ordenes_trabajo>();
        }

        public int Lanzamiento { get; set; }
        public int? Simulacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_lanzamiento { get; set; }
        public DateTime? Fecha_previa_inicio_fabricacion { get; set; }
        public DateTime? Fecha_previa_fin_fabricacion { get; set; }
        public short? Estado { get; set; }
        public DateTime? Fecha_cierre { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public double? Coste_previo_MOD { get; set; }
        public double? Coste_previo_maquina { get; set; }
        public double? Coste_previo_material { get; set; }
        public double? Coste_previo_MOE { get; set; }
        public double? Coste_previo_imp_directa { get; set; }
        public string Codigo_proyecto { get; set; }
        public string Descripcion_ampliada { get; set; }
        public string Descripcion_proyecto { get; set; }
        public string Descripcion_subproyecto { get; set; }
        public string Descripcion_partida { get; set; }
        public double? Coste_previo_indirectos { get; set; }
        public string Descripcion_ampliada_2 { get; set; }
        public double? Coste_medio_previo_material { get; set; }
        public double? UPC_previo_material { get; set; }
        public string Planta { get; set; }

        public virtual ICollection<Lanzamientos_reserva> Lanzamientos_reserva { get; set; }
        public virtual ICollection<Ordenes_trabajo> Ordenes_trabajo { get; set; }
    }
}
