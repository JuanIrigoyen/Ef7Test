using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Planificador_informe
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Articulo { get; set; }
        public string Articulo_descripcion { get; set; }
        public int Fase { get; set; }
        public int? Orden_trabajo { get; set; }
        public string Orden_trabajo_descripcion { get; set; }
        public int? Lanzamiento { get; set; }
        public string Centro_tipo { get; set; }
        public string Centro_grupo { get; set; }
        public string Centro_trabajo { get; set; }
        public string Centro_destino { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public DateTime? Fecha_requerida { get; set; }
        public int Existencias { get; set; }
        public int Lote_entrega { get; set; }
        public int Punto_pedido { get; set; }
        public int PEntrar { get; set; }
        public int Tipo { get; set; }
        public decimal Cantidad_fabricar { get; set; }
        public decimal Cantidad_fabricada { get; set; }
        public int Orden { get; set; }
        public int Dia1 { get; set; }
        public int Dia2 { get; set; }
        public int Dia3 { get; set; }
        public int Dia4 { get; set; }
        public int Dia5 { get; set; }
        public int Dia6 { get; set; }
        public int Dia7 { get; set; }
        public int Semana1 { get; set; }
        public int Semana2 { get; set; }
        public int Semana3 { get; set; }
        public int Semana4 { get; set; }
        public int Estado { get; set; }
        public int Prioridad { get; set; }
        public int Operarios { get; set; }
        public long Tiempo_preparacion { get; set; }
        public long Tiempo_estimado { get; set; }
        public long Tiempo_total { get; set; }
        public bool Traspasado { get; set; }
        public string Observaciones { get; set; }
        public string Incidencias { get; set; }
        public string Usuario { get; set; }
    }
}
