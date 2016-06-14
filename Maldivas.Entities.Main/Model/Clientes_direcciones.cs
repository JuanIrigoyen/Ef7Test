using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_direcciones
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Razon_social { get; set; }
        public string Tipo { get; set; }
        public string Ruta { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Movil1 { get; set; }
        public string Movil2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Voip1 { get; set; }
        public string Voip2 { get; set; }
        public string Internet { get; set; }
        public string Cpostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string Cpais { get; set; }
        public string Pais { get; set; }
        public string Usuario { get; set; }
        public string Clave1 { get; set; }
        public string Clave2 { get; set; }
        public bool Acceso_global { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Direcciones_tipos TipoNavigation { get; set; }
    }
}
