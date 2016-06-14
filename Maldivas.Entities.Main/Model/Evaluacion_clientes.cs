using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Evaluacion_clientes
    {
        public string Cliente { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal Indice_rentabilidad { get; set; }
        public decimal Indice_facturacion { get; set; }
        public decimal Indice_impagados { get; set; }
        public decimal Indice_abonos { get; set; }
        public decimal Valoracion { get; set; }
        public int Ventas_pedidos_servidos_numero { get; set; }
        public decimal Ventas_pedidos_servidos_base_imponible { get; set; }
        public decimal Ventas_pedidos_servidos_base_imponible_media { get; set; }
        public int Ventas_pedidos_unidades_pedidas { get; set; }
        public int Ventas_pedidos_unidades_servidas { get; set; }
        public int Ventas_pedidos_unidades_pendientes { get; set; }
        public int Ventas_albaranes_unidades_vendidas { get; set; }
        public int Ventas_albaranes_unidades_exclusivas { get; set; }
        public int Ventas_albaranes_unidades_no_exclusivas { get; set; }
        public int Ventas_nivel_entrega { get; set; }
        public decimal Ventas_albaranes_unidades_indice { get; set; }
        public int Ventas_facturacion_unidades_abonadas { get; set; }
        public int Ventas_facturacion_unidades_embaladas { get; set; }
        public decimal Ventas_facturacion_base_imponible { get; set; }
        public decimal Ventas_facturacion_total_general { get; set; }
        public decimal Ventas_albaranes_no_facturados_base_imponible { get; set; }
        public decimal Ventas_facturacion_base_imponible_abonos { get; set; }
        public decimal Ventas_facturacion_comision_total { get; set; }
        public decimal Ventas_facturacion_comision_media { get; set; }
        public int Ventas_facturacion_portes_numero { get; set; }
        public decimal Ventas_facturacion_portes_pagados { get; set; }
        public decimal Ventas_facturacion_portes_debidos { get; set; }
        public decimal Ventas_facturacion_portes_coste_real { get; set; }
        public decimal Ventas_facturacion_embalajes_total { get; set; }
        public decimal Ventas_objetivos_prevision { get; set; }
        public decimal Ventas_facturacion_avance { get; set; }
        public decimal Ventas_objetivos_objetivo { get; set; }
        public decimal Ventas_objetivos_indice { get; set; }
        public int Financiera_cartera_ventas_impagados_numero { get; set; }
        public decimal Financiera_cartera_ventas_impagados_total { get; set; }
        public int Ventas_reclamaciones_unidades_reclamadas { get; set; }
        public int Ventas_reclamaciones_unidades_devueltas { get; set; }
        public int Ventas_reclamaciones_unidades_abonadas { get; set; }
        public int Ventas_reclamaciones_unidades_perfectas { get; set; }
        public int Ventas_reclamaciones_unidades_abolladas { get; set; }
        public int Ventas_reclamaciones_unidades_pintadas { get; set; }
        public int Ventas_reclamaciones_unidades_chatarra { get; set; }
        public decimal Ventas_reclamaciones_indice_abonos { get; set; }
        public decimal Ventas_facturacion_abonos_total { get; set; }
        public decimal Ventas_albaranes_abonos_pendientes_total { get; set; }
        public decimal Ventas_abonos_indice { get; set; }
        public int Numero_piezas_vendidas { get; set; }
        public decimal Coste_piezas_vendidas { get; set; }
        public decimal Comisiones { get; set; }
        public decimal Comision_media { get; set; }
        public int Numero_envios_rutas { get; set; }
        public decimal Total_envios_rutas { get; set; }
        public int Numero_envios_agencia_pp { get; set; }
        public decimal Total_envios_agencia_pp { get; set; }
        public int Numero_envios_agencia_pd { get; set; }
        public decimal Total_envios_agencia_pd { get; set; }
    }
}
