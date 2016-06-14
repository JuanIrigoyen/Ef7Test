using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_mantenimiento
    {
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public string Troquel { get; set; }
        public string Proveedor { get; set; }
        public DateTime? Fecha_solicitud { get; set; }
        public DateTime? Fecha_mantenimiento { get; set; }
        public DateTime? Plazo_entrega { get; set; }
        public string Concepto { get; set; }
        public string Descripcion_averia { get; set; }
        public string Descripcion_intervencion { get; set; }
        public string Descripcion_propuesta { get; set; }
        public string Descripcion_causas { get; set; }
        public int? Orden_trabajo { get; set; }
        public bool Conservacion { get; set; }
        public bool Engrase { get; set; }
        public bool Limpieza { get; set; }
        public bool Verificacion { get; set; }
        public bool Pepitas { get; set; }
        public double Horas { get; set; }
        public decimal Coste_materiales { get; set; }
        public decimal Presupuesto { get; set; }
        public string Personal { get; set; }
        public string Responsable { get; set; }
        public string Observaciones { get; set; }
    }
}
