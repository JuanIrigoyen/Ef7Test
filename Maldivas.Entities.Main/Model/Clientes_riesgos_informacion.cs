using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_riesgos_informacion
    {
        public string Cliente { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal Riesgo_actual { get; set; }
        public int Proformas_pendientes_numero { get; set; }
        public decimal Proformas_pendientes_total { get; set; }
        public int Pedidos_pendientes_numero { get; set; }
        public decimal Pedidos_pendientes_total { get; set; }
        public int Cesiones_numero { get; set; }
        public decimal Cesiones_total { get; set; }
        public int Pedidos_curso_numero { get; set; }
        public decimal Pedidos_curso_total { get; set; }
        public int Albaranes_no_facturados_numero { get; set; }
        public decimal Albaranes_no_facturados_total { get; set; }
        public int Facturas_pendientes_cobro_numero { get; set; }
        public decimal Facturas_pendientes_cobro_total { get; set; }
        public int Abonos_pendientes_numero { get; set; }
        public decimal Abonos_pendientes_total { get; set; }
        public int Anticipos_pendientes_numero { get; set; }
        public decimal Anticipos_pendientes_total { get; set; }
        public int Recibos_normales_numero { get; set; }
        public decimal Recibos_normales_total { get; set; }
        public int Recibos_cobrados_numero { get; set; }
        public decimal Recibos_cobrados_total { get; set; }
        public int Recibos_impagados_numero { get; set; }
        public decimal Recibos_impagados_total { get; set; }
        public int Recibos_remesados_numero { get; set; }
        public decimal Recibos_remesados_total { get; set; }
        public int Recibos_nueva_gestion_numero { get; set; }
        public decimal Recibos_nueva_gestion_total { get; set; }
        public int Recibos_nueva_gestion_sg_numero { get; set; }
        public decimal Recibos_nueva_gestion_sg_total { get; set; }
        public int Recibos_nueva_gestion_ampliado_numero { get; set; }
        public decimal Recibos_nueva_gestion_ampliado_total { get; set; }
        public int Recibos_normal_reclamados_numero { get; set; }
        public decimal Recibos_normal_reclamados_total { get; set; }
        public int Recibos_incobrables_numero { get; set; }
        public decimal Recibos_incobrables_total { get; set; }
        public int Recibos_reclamados_numero { get; set; }
        public decimal Recibos_reclamados_total { get; set; }
        public int Recibos_prevision_pago_numero { get; set; }
        public decimal Recibos_prevision_pago_total { get; set; }
        public int Recibos_en_riesgo_numero { get; set; }
        public decimal Recibos_en_riesgo_total { get; set; }
        public int Recibos_no_controlados_numero { get; set; }
        public decimal Recibos_no_controlados_total { get; set; }
    }
}
