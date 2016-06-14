using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_reclamaciones_cabecera
    {
        public Ventas_reclamaciones_cabecera()
        {
            Ventas_reclamaciones_detalle = new HashSet<Ventas_reclamaciones_detalle>();
        }

        public int Codigo { get; set; }
        public string Reclamacion { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Cliente { get; set; }
        public string Cliente_empresa { get; set; }
        public string Referencia { get; set; }
        public string Empresa { get; set; }
        public string Agente { get; set; }
        public string Serie { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha_reclamacion { get; set; }
        public int? Codigo_direccion { get; set; }
        public int? Abono { get; set; }
        public string Abono_codigo { get; set; }
        public DateTime? Abono_fecha { get; set; }
        public string Responsable1 { get; set; }
        public string Responsable2 { get; set; }
        public string Idioma { get; set; }
        public bool Confirmar { get; set; }
        public bool Enviada { get; set; }
        public bool Internet_procesado { get; set; }
        public string Descripcion_reclamacion { get; set; }
        public string Causa_reclamacion { get; set; }
        public string Accion_inmediata { get; set; }
        public string Accion_correctora { get; set; }
        public string Observaciones_generales { get; set; }
        public bool Aprobado { get; set; }

        public virtual ICollection<Ventas_reclamaciones_detalle> Ventas_reclamaciones_detalle { get; set; }
        public virtual Agentes AgenteNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
    }
}
