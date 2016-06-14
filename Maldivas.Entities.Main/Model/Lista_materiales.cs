using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Lista_materiales
    {
        public int Codigo { get; set; }
        public string Articulo_padre { get; set; }
        public string Lista { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public string Sinonimo { get; set; }
        public string Marca { get; set; }
        public int? Cantidad { get; set; }
        public string Norma { get; set; }
        public string Bruto_largo { get; set; }
        public string Bruto_ancho { get; set; }
        public string Bruto_alto { get; set; }
        public string Material { get; set; }
        public string Prioridad { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }
        public string Indice_modificacion_interno { get; set; }
        public string Indice_modificacion_externo { get; set; }
        public DateTime? Fecha_ultima_modificacion { get; set; }
    }
}
