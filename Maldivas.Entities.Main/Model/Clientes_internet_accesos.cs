using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_internet_accesos
    {
        public int Codigo { get; set; }
        public Guid? Sesion { get; set; }
        public DateTime? Expiracion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Cliente { get; set; }
        public int? Direccion { get; set; }
        public string Empresa { get; set; }
        public string Ejercicio { get; set; }
        public string Direccion_ip { get; set; }
        public string Proceso { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
    }
}
