using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Departamentos_tipos
    {
        public Departamentos_tipos()
        {
            Agencias_transporte_departamentos = new HashSet<Agencias_transporte_departamentos>();
            Agentes_departamentos = new HashSet<Agentes_departamentos>();
            Clientes_departamentos = new HashSet<Clientes_departamentos>();
            Competidores_departamentos = new HashSet<Competidores_departamentos>();
            Proveedores_departamentos = new HashSet<Proveedores_departamentos>();
            Talleres_departamentos = new HashSet<Talleres_departamentos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Agencias_transporte_departamentos> Agencias_transporte_departamentos { get; set; }
        public virtual ICollection<Agentes_departamentos> Agentes_departamentos { get; set; }
        public virtual ICollection<Clientes_departamentos> Clientes_departamentos { get; set; }
        public virtual ICollection<Competidores_departamentos> Competidores_departamentos { get; set; }
        public virtual ICollection<Proveedores_departamentos> Proveedores_departamentos { get; set; }
        public virtual ICollection<Talleres_departamentos> Talleres_departamentos { get; set; }
    }
}
