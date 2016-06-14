using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Compras_reclamaciones_cabecera
    {
        public Compras_reclamaciones_cabecera()
        {
            Compras_reclamaciones_detalle = new HashSet<Compras_reclamaciones_detalle>();
        }

        public int Codigo { get; set; }
        public string Reclamacion { get; set; }
        public string Ejercicio { get; set; }
        public string Modo { get; set; }
        public string Proveedor { get; set; }
        public string Proveedor_empresa { get; set; }
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
        public string Accion_inmediata { get; set; }
        public string Accion_correctora { get; set; }
        public string Observaciones_generales { get; set; }
        public bool Aprobado { get; set; }

        public virtual ICollection<Compras_reclamaciones_detalle> Compras_reclamaciones_detalle { get; set; }
    }
}
