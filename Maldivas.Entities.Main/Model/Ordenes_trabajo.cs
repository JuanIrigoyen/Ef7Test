using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ordenes_trabajo
    {
        public int Orden_trabajo { get; set; }
        public int? Orden_trabajo_padre { get; set; }
        public int? Proyecto { get; set; }
        public int? Simulacion { get; set; }
        public int? Lanzamiento { get; set; }
        public int Control { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public int? Fase { get; set; }
        public int? Tipo { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public DateTime? Fecha_ultima_transaccion { get; set; }
        public DateTime? Fecha_requerida { get; set; }
        public decimal Cantidad_fabricar { get; set; }
        public decimal Cantidad_buena { get; set; }
        public decimal Cantidad_defectuosa { get; set; }
        public decimal Cantidad_total { get; set; }
        public decimal Cantidad_pendiente { get; set; }
        public decimal Completado { get; set; }
        public int Orden { get; set; }
        public int Estado { get; set; }
        public int Prioridad { get; set; }
        public string Centro_grupo { get; set; }
        public string Centro_trabajo { get; set; }
        public string Centro_trabajo_destino { get; set; }
        public string Centro_coste { get; set; }
        public int Operarios { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha_inicio_trabajo { get; set; }
        public DateTime? Fecha_final_trabajo { get; set; }
        public long Tiempo_preparacion { get; set; }
        public long Tiempo_estimado { get; set; }
        public long Tiempo_total { get; set; }
        public long Tiempo_real { get; set; }
        public bool Procesar { get; set; }
        public bool Traspasado { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Ordenes_trabajo_estados EstadoNavigation { get; set; }
        public virtual Lanzamientos LanzamientoNavigation { get; set; }
        public virtual Ordenes_trabajo Orden_trabajo_padreNavigation { get; set; }
        public virtual ICollection<Ordenes_trabajo> InverseOrden_trabajo_padreNavigation { get; set; }
        public virtual Prioridades PrioridadNavigation { get; set; }
        public virtual Simulaciones SimulacionNavigation { get; set; }
        public virtual Ordenes_trabajo_tipos TipoNavigation { get; set; }
    }
}
