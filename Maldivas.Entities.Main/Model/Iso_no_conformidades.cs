using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Iso_no_conformidades
    {
        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public DateTime? Fecha { get; set; }
        public string Proveedor { get; set; }
        public string Articulo { get; set; }
        public string Personal { get; set; }
        public int? Numero_factura { get; set; }
        public DateTime? Fecha_entrega { get; set; }
        public bool? Rechazada_entregada { get; set; }
        public int? Cantidad_rechazada { get; set; }
        public bool Calidad { get; set; }
        public bool Cantidad { get; set; }
        public bool Articulo_erroneo { get; set; }
        public bool Otros { get; set; }
        public string Descripcion_reclamacion { get; set; }
        public string Decision { get; set; }
        public string Accion_correctiva { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_informe { get; set; }
        public string Firma_responsable { get; set; }
        public bool Realizacion_AACC { get; set; }
    }
}
