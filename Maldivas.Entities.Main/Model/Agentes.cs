using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agentes
    {
        public Agentes()
        {
            Agentes_departamentos = new HashSet<Agentes_departamentos>();
            Agentes_direcciones = new HashSet<Agentes_direcciones>();
            Agentes_graficos = new HashSet<Agentes_graficos>();
            Agentes_visitas = new HashSet<Agentes_visitas>();
            Ventas_albaranes_cabecera = new HashSet<Ventas_albaranes_cabecera>();
            Ventas_pedidos_cabecera = new HashSet<Ventas_pedidos_cabecera>();
            Ventas_proformas_cabecera = new HashSet<Ventas_proformas_cabecera>();
            Ventas_reclamaciones_cabecera = new HashSet<Ventas_reclamaciones_cabecera>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public int Numero { get; set; }
        public string Nif { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Proveedor { get; set; }
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
        public string Horario_oficina1 { get; set; }
        public string Horario_oficina2 { get; set; }
        public string Vacaciones_inicio { get; set; }
        public string Vacaciones_final { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public bool Bloqueo_operaciones { get; set; }
        public bool Bloqueo_informacion { get; set; }
        public byte Tipo { get; set; }
        public decimal Comision { get; set; }
        public string Divisa { get; set; }
        public string Idioma { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_privadas { get; set; }
        public string Observaciones_administracion { get; set; }
        public string Observaciones_mailing { get; set; }
        public string Observaciones_internet { get; set; }
        public string Internet_grupo { get; set; }
        public bool Internet_acceso { get; set; }

        public virtual ICollection<Agentes_departamentos> Agentes_departamentos { get; set; }
        public virtual ICollection<Agentes_direcciones> Agentes_direcciones { get; set; }
        public virtual ICollection<Agentes_graficos> Agentes_graficos { get; set; }
        public virtual ICollection<Agentes_visitas> Agentes_visitas { get; set; }
        public virtual ICollection<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual ICollection<Ventas_pedidos_cabecera> Ventas_pedidos_cabecera { get; set; }
        public virtual ICollection<Ventas_proformas_cabecera> Ventas_proformas_cabecera { get; set; }
        public virtual ICollection<Ventas_reclamaciones_cabecera> Ventas_reclamaciones_cabecera { get; set; }
    }
}
