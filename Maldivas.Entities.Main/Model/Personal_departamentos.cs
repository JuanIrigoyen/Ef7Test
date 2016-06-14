using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_departamentos
    {
        public Personal_departamentos()
        {
            Compras_albaranes_cabecera = new HashSet<Compras_albaranes_cabecera>();
            Compras_facturas_cabecera = new HashSet<Compras_facturas_cabecera>();
            Compras_pedidos_cabecera = new HashSet<Compras_pedidos_cabecera>();
            Compras_proformas_cabecera = new HashSet<Compras_proformas_cabecera>();
            Personal = new HashSet<Personal>();
        }

        public string Codigo { get; set; }
        public string Padre { get; set; }
        public string Abreviatura { get; set; }
        public string Seccion { get; set; }
        public string Departamento { get; set; }
        public string Almacen { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string CPais { get; set; }
        public string Pais { get; set; }
        public string CPostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Movil1 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string VoIp1 { get; set; }
        public string VoIp2 { get; set; }
        public string Internet { get; set; }
        public string Ftp { get; set; }
        public string Tipo_tarea { get; set; }
        public string Responsable { get; set; }
        public byte[] Firma { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public byte[] Imagen3 { get; set; }
        public string Ubicacion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }
        public string Observaciones { get; set; }
        public bool Compras { get; set; }
        public bool Ventas { get; set; }

        public virtual ICollection<Compras_albaranes_cabecera> Compras_albaranes_cabecera { get; set; }
        public virtual ICollection<Compras_facturas_cabecera> Compras_facturas_cabecera { get; set; }
        public virtual ICollection<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual ICollection<Compras_proformas_cabecera> Compras_proformas_cabecera { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
