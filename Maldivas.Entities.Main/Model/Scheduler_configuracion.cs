using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Scheduler_configuracion
    {
        public Scheduler_configuracion()
        {
            Scheduler_destinatarios = new HashSet<Scheduler_destinatarios>();
            Scheduler_log = new HashSet<Scheduler_log>();
            Scheduler_parameters = new HashSet<Scheduler_parameters>();
        }

        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha_creacion { get; set; }
        public DateTime? Fecha_proxima_ejecucion { get; set; }
        public DateTime? Fecha_ultima_ejecucion { get; set; }
        public string Descripcion { get; set; }
        public string Sujeto { get; set; }
        public string Cuerpo { get; set; }
        public string Query { get; set; }
        public string Observaciones { get; set; }
        public string Idioma { get; set; }
        public int? Estadistica { get; set; }
        public int? Informe { get; set; }
        public bool Exportar_pdf { get; set; }
        public bool Exportar_excel { get; set; }
        public bool Exportar_word { get; set; }
        public bool Exportar_html { get; set; }
        public bool Exportar_csv { get; set; }
        public bool Exportar_mht { get; set; }
        public bool Exportar_txt { get; set; }
        public DateTime? Frecuencia_unica_fecha { get; set; }
        public byte Frecuencia_tipo { get; set; }
        public short Frecuencia_diaria_dias { get; set; }
        public short Frecuencia_semanal_semanas { get; set; }
        public bool Frecuencia_semanal_lunes { get; set; }
        public bool Frecuencia_semanal_martes { get; set; }
        public bool Frecuencia_semanal_miercoles { get; set; }
        public bool Frecuencia_semanal_jueves { get; set; }
        public bool Frecuencia_semanal_viernes { get; set; }
        public bool Frecuencia_semanal_sabado { get; set; }
        public bool Frecuencia_semanal_domingo { get; set; }
        public bool Frecuencia_mensual_tipo { get; set; }
        public short Frecuencia_mensual_diaria_dia { get; set; }
        public short Frecuencia_mensual_diaria_mes { get; set; }
        public short Frecuencia_mensual_periodo_ambito { get; set; }
        public short Frecuencia_mensual_periodo_dias { get; set; }
        public short Frecuencia_mensual_periodo_mes { get; set; }
        public bool Frecuencia_ejecucion { get; set; }
        public DateTime? Frecuencia_hora_ejecucion { get; set; }
        public byte Frecuencia_periodo_tipo { get; set; }
        public short Frecuencia_periodo { get; set; }
        public DateTime? Frecuencia_hora_inicio { get; set; }
        public DateTime? Frecuencia_hora_final { get; set; }
        public bool Frecuencia_finalizacion { get; set; }
        public DateTime? Duracion_fecha_inicial { get; set; }
        public DateTime? Duracion_fecha_final { get; set; }
        public string Frecuencia_descripcion { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Scheduler_destinatarios> Scheduler_destinatarios { get; set; }
        public virtual ICollection<Scheduler_log> Scheduler_log { get; set; }
        public virtual ICollection<Scheduler_parameters> Scheduler_parameters { get; set; }
        public virtual Estadisticas EstadisticaNavigation { get; set; }
        public virtual Informes InformeNavigation { get; set; }
    }
}
