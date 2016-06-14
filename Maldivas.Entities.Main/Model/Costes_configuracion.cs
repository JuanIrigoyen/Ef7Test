using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Costes_configuracion
    {
        public int Codigo { get; set; }
        public string Almacen { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_ultima_actualización { get; set; }
        public DateTime? Fecha_proxima_ejecucion { get; set; }
        public int Periodicidad { get; set; }
        public int Demanda_media_meses { get; set; }
        public decimal Volumen_util { get; set; }
        public decimal Superficie_estanterias { get; set; }
        public decimal Almacen_altura { get; set; }
        public decimal Almacen_aprovechamiento { get; set; }
        public decimal Coste_alquiler { get; set; }
        public string Coste_alquiler_descripcion { get; set; }
        public decimal Coste_estanterias { get; set; }
        public decimal Coste_energia { get; set; }
        public int Operarios_desplazamiento { get; set; }
        public short Dias_laborables { get; set; }
        public decimal Coste_operario { get; set; }
        public string Coste_operario_descripcion { get; set; }
        public decimal Coste_mano_obra { get; set; }
        public decimal Coste_medios_transporte { get; set; }
        public string Coste_medios_transporte_descripcion { get; set; }
        public decimal Coste_carretillas { get; set; }
        public decimal Total_coste_medios { get; set; }
        public decimal Total_coste_volumen { get; set; }
        public decimal Total_coste_mantenimiento_volumen { get; set; }
        public decimal Coste_preparacion_linea_prensas { get; set; }
        public string Coste_preparacion_linea_prensas_descripcion { get; set; }
        public decimal Coste_preparacion_linea_engatillado { get; set; }
        public string Coste_preparacion_linea_engatillado_descripcion { get; set; }
        public decimal Coste_preparacion_linea_soldadura { get; set; }
        public string Coste_preparacion_linea_soldadura_descripcion { get; set; }
        public decimal Coste_preparacion_interna_operarios { get; set; }
        public decimal Coste_preparacion_externa_operarios { get; set; }
        public decimal Coste_preparacion_fijo { get; set; }
        public decimal Coste_hora_maquina_parada { get; set; }
        public decimal Coste_financiacion { get; set; }
        public decimal Coste_seguro_contenido { get; set; }
        public decimal Coste_obsolescencia { get; set; }
        public decimal Coste_mantenimiento_financiero { get; set; }
        public bool Imputacion_coste_maquina_parada { get; set; }
        public decimal Porcentaje_nacional_inmediato { get; set; }
        public decimal Volumen_jaula { get; set; }
        public decimal Volumen_medio { get; set; }
        public int Stock_seguridad { get; set; }
        public int Punto_pedido_stock_minimo { get; set; }
        public int Punto_pedido_stock_seguridad { get; set; }
        public int Lote_entrega_stock_minimo { get; set; }
        public int Lote_entrega_stock_seguridad { get; set; }
        public string Observaciones { get; set; }
    }
}
