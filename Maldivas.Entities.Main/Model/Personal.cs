using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal
    {
        public Personal()
        {
            Anticipos = new HashSet<Anticipos>();
            Articulos_movimientos = new HashSet<Articulos_movimientos>();
            Personal_absentismo = new HashSet<Personal_absentismo>();
            Personal_calendarios = new HashSet<Personal_calendarios>();
            Personal_categorias_historico = new HashSet<Personal_categorias_historico>();
            Personal_equipamiento_movimientos = new HashSet<Personal_equipamiento_movimientos>();
            Personal_formacion = new HashSet<Personal_formacion>();
            Personal_formacion_idiomas = new HashSet<Personal_formacion_idiomas>();
            Personal_grupos_trabajo_relacion = new HashSet<Personal_grupos_trabajo_relacion>();
            Personal_presencia = new HashSet<Personal_presencia>();
            Ventas_albaranes_carga_operarios = new HashSet<Ventas_albaranes_carga_operarios>();
        }

        public string Codigo { get; set; }
        public string Nif { get; set; }
        public string Subcuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre_completo { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Cpostal { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string Pais { get; set; }
        public string CPais { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Movil1 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Voip1 { get; set; }
        public string Voip2 { get; set; }
        public string Internet { get; set; }
        public DateTime? Fecha_nacimiento { get; set; }
        public string Lugar_nacimiento { get; set; }
        public string Provincia_nacimiento { get; set; }
        public string Pais_nacimiento { get; set; }
        public DateTime? Fecha_ingreso { get; set; }
        public DateTime? Fecha_final { get; set; }
        public string Departamento { get; set; }
        public string Responsable { get; set; }
        public string Especialidad { get; set; }
        public string Categoria { get; set; }
        public string Evaluacion { get; set; }
        public bool Candidato { get; set; }
        public string Seguridad_social_numero { get; set; }
        public string Seguridad_social_codigo_contrato { get; set; }
        public string Seguridad_social_epigrafe { get; set; }
        public string Seguridad_social_grupo_cotizacion { get; set; }
        public string Destino { get; set; }
        public string Turno { get; set; }
        public string Centro_preferente { get; set; }
        public string Prima_asistencia_puntualidad { get; set; }
        public string Prima_Produccion { get; set; }
        public bool Absentismo { get; set; }
        public bool Activo { get; set; }
        public bool Presencia { get; set; }
        public bool En_cartera { get; set; }
        public string Numero_tarjeta_reloj { get; set; }
        public string Empresa { get; set; }
        public string Grafico { get; set; }
        public byte[] Imagen { get; set; }
        public string Sexo { get; set; }
        public DateTime? Fecha_fin_contrato { get; set; }
        public string Observaciones { get; set; }
        public bool Filtro { get; set; }

        public virtual ICollection<Anticipos> Anticipos { get; set; }
        public virtual ICollection<Articulos_movimientos> Articulos_movimientos { get; set; }
        public virtual ICollection<Personal_absentismo> Personal_absentismo { get; set; }
        public virtual ICollection<Personal_calendarios> Personal_calendarios { get; set; }
        public virtual ICollection<Personal_categorias_historico> Personal_categorias_historico { get; set; }
        public virtual ICollection<Personal_equipamiento_movimientos> Personal_equipamiento_movimientos { get; set; }
        public virtual ICollection<Personal_formacion> Personal_formacion { get; set; }
        public virtual ICollection<Personal_formacion_idiomas> Personal_formacion_idiomas { get; set; }
        public virtual ICollection<Personal_grupos_trabajo_relacion> Personal_grupos_trabajo_relacion { get; set; }
        public virtual ICollection<Personal_presencia> Personal_presencia { get; set; }
        public virtual ICollection<Ventas_albaranes_carga_operarios> Ventas_albaranes_carga_operarios { get; set; }
        public virtual Personal_departamentos DepartamentoNavigation { get; set; }
        public virtual Personal_empresas EmpresaNavigation { get; set; }
        public virtual Personal_especialidades EspecialidadNavigation { get; set; }
        public virtual Personal_prima_produccion Prima_ProduccionNavigation { get; set; }
        public virtual Personal_prima_asistencia_puntualidad Prima_asistencia_puntualidadNavigation { get; set; }
        public virtual Personal_seguridad_social_epigrafes Seguridad_social_epigrafeNavigation { get; set; }
        public virtual Personal_seguridad_social_grupo_cotizacion Seguridad_social_grupo_cotizacionNavigation { get; set; }
        public virtual Personal_turnos TurnoNavigation { get; set; }
    }
}
