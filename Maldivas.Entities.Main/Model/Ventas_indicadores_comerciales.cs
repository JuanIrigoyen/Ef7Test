using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_indicadores_comerciales
    {
        public string Ejercicio { get; set; }
        public DateTime Fecha_actualizacion { get; set; }
        public decimal Ventas_totales_real { get; set; }
        public decimal Ventas_totales_presupuestado { get; set; }
        public decimal Ventas_totales_avance { get; set; }
        public short Ventas_totales_clientes { get; set; }
        public short Ventas_totales_zonas { get; set; }
        public int Ventas_totales_unidades { get; set; }
        public decimal Ventas_exportacion_real { get; set; }
        public decimal Ventas_exportacion_presupuestado { get; set; }
        public decimal Ventas_exportacion_avance { get; set; }
        public short Ventas_exportacion_clientes { get; set; }
        public short Ventas_exportacion_zonas { get; set; }
        public int Ventas_exportacion_unidades { get; set; }
        public decimal Ventas_nacionales_real { get; set; }
        public decimal Ventas_nacionales_presupuestado { get; set; }
        public decimal Ventas_nacionales_avance { get; set; }
        public short Ventas_nacionales_clientes { get; set; }
        public short Ventas_nacionales_zonas { get; set; }
        public int Ventas_nacionales_unidades { get; set; }
        public decimal Ventas_unidades_aletas { get; set; }
        public decimal Ventas_unidades_capots { get; set; }
        public decimal Ventas_unidades_frentes { get; set; }
        public decimal Ventas_unidades_varios { get; set; }
        public decimal Objetivo_aletas { get; set; }
        public decimal Objetivo_capots { get; set; }
        public decimal Objetivo_frentes { get; set; }
        public decimal Objetivo_varios { get; set; }
        public decimal Avance_aletas { get; set; }
        public decimal Avance_capots { get; set; }
        public decimal Avance_frentes { get; set; }
        public decimal Avance_varios { get; set; }
        public decimal Porcentaje_total_aletas { get; set; }
        public decimal Porcentaje_total_capots { get; set; }
        public decimal Porcentaje_total_frentes { get; set; }
        public decimal Porcentaje_total_varios { get; set; }
        public int Referencias_vivas { get; set; }
        public int Ventas_por_referencia { get; set; }
        public int VPiezas_menor_tres_unidades { get; set; }
        public decimal VPiezas_menor_tres_porcentaje { get; set; }
        public int VPiezas_menor_tres_referencias { get; set; }
        public int VPiezas_menor_tres_media { get; set; }
        public int VPiezas_tres_seis_unidades { get; set; }
        public decimal VPiezas_tres_seis_porcentaje { get; set; }
        public int VPiezas_tres_seis_referencias { get; set; }
        public int VPiezas_tres_seis_media { get; set; }
        public int VPiezas_mayor_seis_unidades { get; set; }
        public decimal VPiezas_mayor_seis_porcentaje { get; set; }
        public int VPiezas_mayor_seis_referencias { get; set; }
        public int VPiezas_mayor_seis_media { get; set; }
        public decimal Venta_piezas_empleado_numero { get; set; }
        public decimal Venta_piezas_empleado_ratio { get; set; }
        public decimal Coste_piezas_empleado { get; set; }
        public int Nivel_servicio_unidades_pedidas { get; set; }
        public int Nivel_servicio_unidades_servidas { get; set; }
        public decimal Nivel_servicio_ratio { get; set; }
    }
}
