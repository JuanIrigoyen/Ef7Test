using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Costes_articulos_configuracion
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public decimal Tiempo_preparacion_interna { get; set; }
        public decimal Operarios_preparacion_interna { get; set; }
        public decimal Tiempo_preparacion_externa { get; set; }
        public decimal Operarios_preparacion_externa { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Demanda_media { get; set; }
        public decimal Volumen_jaula { get; set; }
        public decimal Coste_mano_obra { get; set; }
        public decimal Coste_preparacion { get; set; }
        public decimal Coste_financiacion { get; set; }
        public decimal Coste_obsolescencia { get; set; }
        public decimal Coste_seguro_contenido { get; set; }
        public decimal Coste_mantenimiento_fijo { get; set; }
        public decimal Coste_alquiler { get; set; }
        public decimal Coste_energia { get; set; }
        public decimal Coste_manipulacion { get; set; }
        public decimal Coste_medios { get; set; }
        public decimal Coste_mantenimiento_variable { get; set; }
        public decimal Coste_mantenimiento { get; set; }
        public decimal Lote_entrega_calculado { get; set; }
        public decimal Lote_entrega_actual { get; set; }
        public decimal Punto_pedido_calculado { get; set; }
        public decimal Punto_pedido_actual { get; set; }
        public DateTime Fecha_ultima_actualizacion { get; set; }
        public decimal Coste_optimo { get; set; }
        public decimal Coste_actual { get; set; }
    }
}
