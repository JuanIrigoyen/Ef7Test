using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Competidores
    {
        public Competidores()
        {
            Competidores_articulos_certificados = new HashSet<Competidores_articulos_certificados>();
            Competidores_departamentos = new HashSet<Competidores_departamentos>();
            Competidores_ofertas = new HashSet<Competidores_ofertas>();
            Competidores_sinonimos = new HashSet<Competidores_sinonimos>();
            Competidores_visitas = new HashSet<Competidores_visitas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public int Numero { get; set; }
        public string Nif { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string Pais { get; set; }
        public string Cpais { get; set; }
        public string Cpostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Movil1 { get; set; }
        public string Movil2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Voip1 { get; set; }
        public string Voip2 { get; set; }
        public string Zona { get; set; }
        public string Internet { get; set; }
        public string Ftp { get; set; }
        public string Usuario { get; set; }
        public string Clave1 { get; set; }
        public string Clave2 { get; set; }
        public string Clave3 { get; set; }
        public string Horario_oficina1 { get; set; }
        public string Horario_oficina2 { get; set; }
        public string Horario_descarga1 { get; set; }
        public string Horario_descarga2 { get; set; }
        public string Vacaciones_inicio { get; set; }
        public string Vacaciones_final { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public bool Bloqueo_operaciones { get; set; }
        public bool Bloqueo_informacion { get; set; }
        public string Grupo_sinonimos { get; set; }
        public string Divisa { get; set; }
        public string Idioma { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_privadas { get; set; }
        public string Observaciones_administracion { get; set; }

        public virtual ICollection<Competidores_articulos_certificados> Competidores_articulos_certificados { get; set; }
        public virtual ICollection<Competidores_departamentos> Competidores_departamentos { get; set; }
        public virtual ICollection<Competidores_ofertas> Competidores_ofertas { get; set; }
        public virtual ICollection<Competidores_sinonimos> Competidores_sinonimos { get; set; }
        public virtual ICollection<Competidores_visitas> Competidores_visitas { get; set; }
    }
}
