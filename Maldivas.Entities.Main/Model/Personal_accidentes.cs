﻿using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_accidentes
    {
        public string Codigo { get; set; }
        public string Referencia { get; set; }
        public short? Oran_codigo_accidente { get; set; }
        public DateTime? Oran_fecha_informe { get; set; }
        public string Oran_operario { get; set; }
        public string Oran_departamento { get; set; }
        public string Oran_lugar { get; set; }
        public string Oran_maquina { get; set; }
        public string Oran_responsable { get; set; }
        public string Oran_testigo { get; set; }
        public string Oran_turno { get; set; }
        public short? Oran_jornadas_perdidas { get; set; }
        public string Oran_empresa { get; set; }
        public DateTime? Oran_accidente_alta { get; set; }
        public bool Oran_baja_accidente { get; set; }
        public string Oran_repeticion { get; set; }
        public string Oran_AACC_medidas { get; set; }
        public DateTime? Oran_AACC_inicio { get; set; }
        public DateTime? Oran_AACC_final { get; set; }
        public DateTime? Oran_AACC_revision { get; set; }
        public string Oran_investigador { get; set; }
        public string Oran_revisado { get; set; }
        public string Tipo { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
        public string NSS { get; set; }
        public DateTime? Fecha_ingreso { get; set; }
        public string Sexo { get; set; }
        public DateTime? Fecha_nacimiento { get; set; }
        public string Pais { get; set; }
        public string DNI { get; set; }
        public string Situacion { get; set; }
        public string CNO { get; set; }
        public string CNO_codigo { get; set; }
        public string Contrato { get; set; }
        public string Regimen_SS { get; set; }
        public string Texto_convenio { get; set; }
        public string Trabajador_atep { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string Codigo_postal { get; set; }
        public string Empresa_nif { get; set; }
        public string Empresa_razon { get; set; }
        public string Empresa_NSS { get; set; }
        public string Empresa_CNAE_texto { get; set; }
        public string Empresa_CNAE_codigo { get; set; }
        public int? Empresa_plantilla { get; set; }
        public string Empresa_domicilio { get; set; }
        public string Empresa_provincia { get; set; }
        public string Empresa_municipio { get; set; }
        public string Empresa_codigo_postal { get; set; }
        public string Empresa_telefono { get; set; }
        public bool Empresa_contrata { get; set; }
        public bool Empresa_ett { get; set; }
        public bool Empresa_preventiva_asumida_empresario { get; set; }
        public bool Empresa_preventiva_propia { get; set; }
        public bool Empresa_preventiva_ajena { get; set; }
        public bool Empresa_preventiva_trabajador_designado { get; set; }
        public bool Empresa_preventiva_mancomunado { get; set; }
        public bool Empresa_preventiva_ninguna { get; set; }
        public string Accidente_lugar { get; set; }
        public bool? Accidente_trafico { get; set; }
        public string Accidente_pais { get; set; }
        public string Accidente_provincia { get; set; }
        public string Accidente_municipio { get; set; }
        public string Accidente_direccion { get; set; }
        public string Accidente_via_km { get; set; }
        public bool Accidente_centro_pertenece_empresa { get; set; }
        public bool Accidente_centro_coincide_empresa { get; set; }
        public string Accidente_centro_CIF_contrata { get; set; }
        public string Accidente_centro_CIF_ett { get; set; }
        public string Accidente_centro_CIF_otra { get; set; }
        public string Accidente_empresa_razon_social { get; set; }
        public string Accidente_empresa_domicilio { get; set; }
        public string Accidente_empresa_provincia { get; set; }
        public string Accidente_empresa_municipio { get; set; }
        public string Accidente_empresa_codigo_postal { get; set; }
        public string Accidente_empresa_telefono { get; set; }
        public int? Accidente_empresa_plantilla { get; set; }
        public string Accidente_empresa_CIF { get; set; }
        public string Accidente_empresa_CNAE_texto { get; set; }
        public string Accidente_empresa_CNAE_codigo { get; set; }
        public DateTime? Accidente_fecha_accidente { get; set; }
        public DateTime? Accidente_fecha_baja { get; set; }
        public byte? Accidente_hora_trabajo { get; set; }
        public bool Accidente_habitual { get; set; }
        public bool Accidente_evaluacion { get; set; }
        public string Accidente_descripcion { get; set; }
        public string Accidente_ampliacion_entorno_lugar { get; set; }
        public string Accidente_ampliacion_tipo_lugar { get; set; }
        public string Accidente_ampliacion_proceso_trabajo { get; set; }
        public string Accidente_ampliacion_proceso_tipo_trabajo { get; set; }
        public string Accidente_ampliacion_tarea_actividad { get; set; }
        public string Accidente_ampliacion_tarea_especifica { get; set; }
        public string Accidente_ampliacion_desencadenante_hecho { get; set; }
        public string Accidente_ampliacion_desencadenante_desviacion { get; set; }
        public string Accidente_ampliacion_desencadenante_agente { get; set; }
        public string Accidente_ampliacion_modo { get; set; }
        public string Accidente_ampliacion_forma_lesion { get; set; }
        public string Accidente_ampliacion_objeto_implicado_codigo { get; set; }
        public string Accidente_ampliacion_objeto_implicado { get; set; }
        public string Accidente_ampliacion_objeto { get; set; }
        public bool? Accidente_ampliacion_multiples_operarios { get; set; }
        public bool? Accidente_ampliacion_testigos { get; set; }
        public string Accidente_ampliacion_datostestigos { get; set; }
        public string Asistenciales_lesion { get; set; }
        public string Asistenciales_grado { get; set; }
        public string Asistenciales_parte { get; set; }
        public string Asistenciales_medico_nombre { get; set; }
        public string Asistenciales_medico_domicilio { get; set; }
        public string Asistenciales_medico_telefono { get; set; }
        public string Asistenciales_tipo_asistencia { get; set; }
        public bool Asistenciales_hospital_codigo { get; set; }
        public string Asistenciales_hospital_nombre { get; set; }
        public decimal Economicos_mensual_mes_anterior { get; set; }
        public int Economicos_mensual_dias { get; set; }
        public int Economicos_dias_ejercicio { get; set; }
        public decimal Economicos_anual_B1 { get; set; }
        public decimal Economicos_anual_B2 { get; set; }
        public string Actores_empresa_nombre_apellidos { get; set; }
        public string Actores_empresa_cargo { get; set; }
        public string Actores_empresa_provincia { get; set; }
        public DateTime? Actores_empresa_fecha_presentacion { get; set; }
        public string Actores_empresa_entidad_gestora_codigo { get; set; }
        public decimal Traspasado { get; set; }

        public virtual Personal_accidentes_CNO CNO_codigoNavigation { get; set; }
        public virtual Personal_accidentes_CNAE Empresa_CNAE_codigoNavigation { get; set; }
    }
}
